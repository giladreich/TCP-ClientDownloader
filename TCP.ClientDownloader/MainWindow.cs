using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP.ClientDownloader
{
    public partial class MainWindow : Form
    {
        private string _baseUrl;
        private string _fileName;
        private int _iFrom;
        private int _iTo;
        private string _extension;
        private string _dstPath;
        private bool _stopParsing;

        private Queue<Uri> _downloadUrls;
        private CancellationTokenSource _tokenSource;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbxExtension.SelectedIndex = 0;
            tbxDstPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            _stopParsing = false;
            _dstPath = Path.Combine(_dstPath, "Download_Result");
            Directory.CreateDirectory(_dstPath);

            UIUpdateStart();
            InitDownloadLinks();

            await StartDownload();

            MessageBox.Show("File downloaded at: \n" + _dstPath, "DONE",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (cbxOpenDst.Checked)
                Process.Start("explorer.exe", _dstPath);

            UIUpdateStop();
        }

        private bool ValidateFields()
        {
            _baseUrl   = tbxUrl.Text;
            _fileName  = tbxFileName.Text;
            _extension = cbxExtension.Text;
            _dstPath   = tbxDstPath.Text;

            if (!Directory.Exists(_dstPath))
            {
                MessageBox.Show("Invalid destination path.", "Invalid Input");
                return false;
            }

            bool isParseFailed = !int.TryParse(tbxFrom.Text, out _iFrom) || !int.TryParse(tbxTo.Text, out _iTo);
            if (isParseFailed && _iFrom >= _iTo)
            {
                MessageBox.Show("Invalid input in TextBox \"From\" OR \"To\".", "Invalid Input");
                return false;
            }

            return true;
        }

        private void InitDownloadLinks()
        {
            _downloadUrls = new Queue<Uri>();

            for (int i = _iFrom; i <= _iTo; i++)
                _downloadUrls.Enqueue(new Uri($"{_baseUrl}/{_fileName}{i}{_extension}"));
        }

        private async Task StartDownload()
        {
            _tokenSource = new CancellationTokenSource();
            CancellationToken token = _tokenSource.Token;

            using (WebClient client = new WebClient())
            {
                token.Register(client.CancelAsync);
                client.DownloadProgressChanged += OnProgressChanged;
                client.DownloadFileCompleted   += OnDownloadFileCompleted;

                await ProccessUrls(client);
            }
        }

        private void OnProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblBytes.Text = $"Bytes: {e.BytesReceived} / {e.TotalBytesToReceive}";
        }

        private void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string fileName = ((WebClient)sender).QueryString["fileName"];
            lblProgress.Text = $"Downloading File {fileName} / {_fileName}{_iTo}{_extension}";
        }

        private async Task ProccessUrls(WebClient client)
        {
            foreach (Uri uri in _downloadUrls)
            {
                string fileName = uri.Segments.Last();
                string filePath = Path.Combine(_dstPath, fileName);
                client.QueryString = new NameValueCollection { { "fileName", fileName } };

                try
                {
                    if (_stopParsing) return;

                    await client.DownloadFileTaskAsync(uri, filePath);
                }
                catch (WebException ex)
                {
                    FallBack(filePath);
                    if (cbxIgnoreMsgs.Checked && ex.Status != WebExceptionStatus.RequestCanceled) continue;
                    if (!ShouldContinue(ex.Message, "INFO", MessageBoxIcon.Information, ex)) break;
                }
                catch (Exception ex)
                {
                    FallBack(filePath);
                    if (cbxIgnoreMsgs.Checked) continue;
                    if (!ShouldContinue(ex.Message, "ERROR", MessageBoxIcon.Error)) break;
                }
            }
        }

        private static void FallBack(string filePath)
        {
            File.Delete(filePath);
        }

        private bool ShouldContinue(string message, string caption, MessageBoxIcon icon, WebException webException = null)
        {
            DialogResult result;

            if (webException != null)
            {
                switch (webException.Status)
                {
                    case WebExceptionStatus.ConnectFailure:
                    case WebExceptionStatus.Timeout:
                        result = MessageBox.Show(
                            message + "\nTo continue? \nYes if you want to try again. No to cancel.",
                            "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        break;
                    
                    case WebExceptionStatus.RequestCanceled:
                        return false;

                    default:
                        result = MessageBox.Show(
                            message + "\nTo continue? \nYes if you want to download rest of the files. No to cancel." +
                            "\nNOTE: If this annoys you, just check the check box for Ignoring Messages.",
                            caption, MessageBoxButtons.YesNo, icon);
                        break;
                }
            }
            else
            {
                
                result = MessageBox.Show(
                    message + "\nTo continue? \nYes if you want to download rest of the files. No to cancel." +
                    "\nNOTE: If this annoys you, just check the check box for Ignoring Messages.",
                    caption, MessageBoxButtons.YesNo, icon);
            }

            return result == DialogResult.Yes;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();
            _stopParsing = true;
        }

        private void btnDstPicker_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() != DialogResult.OK) return;

            tbxDstPath.Text = fbd.SelectedPath;
        }

        private void UIUpdateStart()
        {
            btnStop.Enabled       = true;
            progressBar.Visible   = true;
            lblProgress.Visible   = true;
            lblBytes.Visible      = true;

            btnStart.Enabled      = false;
            btnDstPicker.Enabled  = false;
            tbxUrl.Enabled        = false;
            tbxFileName.Enabled   = false;
            tbxTo.Enabled         = false;
            tbxFrom.Enabled       = false;
            tbxDstPath.Enabled    = false;
            cbxIgnoreMsgs.Enabled = false;
            cbxOpenDst.Enabled    = false;
            cbxExtension.Enabled  = false;

            Size                  = new Size(425, 313);
            lblProgress.Text      = $"Downloading {_fileName}{_iFrom}{_extension} / {_fileName}{_iTo}{_extension}";
        }

        private void UIUpdateStop()
        {
            btnStop.Enabled       = false;
            progressBar.Visible   = false;
            lblProgress.Visible   = false;
            lblBytes.Visible      = false;

            btnStart.Enabled      = true;
            btnDstPicker.Enabled  = true;
            tbxUrl.Enabled        = true;
            tbxFileName.Enabled   = true;
            tbxTo.Enabled         = true;
            tbxFrom.Enabled       = true;
            tbxDstPath.Enabled    = true;
            cbxIgnoreMsgs.Enabled = true;
            cbxOpenDst.Enabled    = true;
            cbxExtension.Enabled  = true;

            Size              = new Size(425, 248);
            _downloadUrls     = null;
            lblProgress.Text  = "Downloading 0 / 0";
            lblBytes.Text     = "Bytes: ";
            progressBar.Value = 0;
            _iFrom            = 0;
            _iTo              = 0;
        }
    }
}
