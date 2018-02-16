namespace TCP.ClientDownloader
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tbxDstPath = new System.Windows.Forms.TextBox();
            this.btnDstPicker = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbxIgnoreMsgs = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxOpenDst = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblBytes = new System.Windows.Forms.Label();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxExtension = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxDstPath
            // 
            this.tbxDstPath.Location = new System.Drawing.Point(26, 153);
            this.tbxDstPath.Name = "tbxDstPath";
            this.tbxDstPath.Size = new System.Drawing.Size(328, 20);
            this.tbxDstPath.TabIndex = 5;
            // 
            // btnDstPicker
            // 
            this.btnDstPicker.Location = new System.Drawing.Point(360, 152);
            this.btnDstPicker.Name = "btnDstPicker";
            this.btnDstPicker.Size = new System.Drawing.Size(24, 20);
            this.btnDstPicker.TabIndex = 6;
            this.btnDstPicker.Text = "...";
            this.toolTip.SetToolTip(this.btnDstPicker, "Pick a destination path.");
            this.btnDstPicker.UseVisualStyleBackColor = true;
            this.btnDstPicker.Click += new System.EventHandler(this.btnDstPicker_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Path:";
            this.toolTip.SetToolTip(this.label2, "The location where the files will be stored in.");
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(76, 179);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start Downloading";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbxFrom
            // 
            this.tbxFrom.Location = new System.Drawing.Point(43, 17);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(50, 20);
            this.tbxFrom.TabIndex = 0;
            this.tbxFrom.Text = "1";
            // 
            // tbxTo
            // 
            this.tbxTo.Location = new System.Drawing.Point(124, 17);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(50, 20);
            this.tbxTo.TabIndex = 1;
            this.tbxTo.Text = "86";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(26, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download Range";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(199, 179);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(117, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop Downloading";
            this.toolTip.SetToolTip(this.btnStop, "Cancel the download operation.");
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbxIgnoreMsgs
            // 
            this.cbxIgnoreMsgs.AutoSize = true;
            this.cbxIgnoreMsgs.Location = new System.Drawing.Point(6, 19);
            this.cbxIgnoreMsgs.Name = "cbxIgnoreMsgs";
            this.cbxIgnoreMsgs.Size = new System.Drawing.Size(107, 17);
            this.cbxIgnoreMsgs.TabIndex = 0;
            this.cbxIgnoreMsgs.Text = "Ignore Messages";
            this.toolTip.SetToolTip(this.cbxIgnoreMsgs, "Will skip the file when there is an error thrown. ");
            this.cbxIgnoreMsgs.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxOpenDst);
            this.groupBox2.Controls.Add(this.cbxIgnoreMsgs);
            this.groupBox2.Location = new System.Drawing.Point(248, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 67);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurations";
            // 
            // cbxOpenDst
            // 
            this.cbxOpenDst.AutoSize = true;
            this.cbxOpenDst.Checked = true;
            this.cbxOpenDst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOpenDst.Location = new System.Drawing.Point(6, 42);
            this.cbxOpenDst.Name = "cbxOpenDst";
            this.cbxOpenDst.Size = new System.Drawing.Size(127, 17);
            this.cbxOpenDst.TabIndex = 1;
            this.cbxOpenDst.Text = "Open Patch Location";
            this.toolTip.SetToolTip(this.cbxOpenDst, "Once download is finished, the location where files are saved will be opened auto" +
        "matically.");
            this.cbxOpenDst.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(90, 227);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(208, 23);
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(33, 211);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(334, 13);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "Downloading 0 / 0";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblProgress.Visible = false;
            // 
            // lblBytes
            // 
            this.lblBytes.AutoSize = true;
            this.lblBytes.Location = new System.Drawing.Point(124, 253);
            this.lblBytes.Name = "lblBytes";
            this.lblBytes.Size = new System.Drawing.Size(39, 13);
            this.lblBytes.TabIndex = 8;
            this.lblBytes.Text = "Bytes: ";
            this.lblBytes.Visible = false;
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(73, 12);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(328, 20);
            this.tbxUrl.TabIndex = 0;
            this.tbxUrl.Text = "ftp://192.168.2.1/SomeStuff";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL:";
            this.toolTip.SetToolTip(this.label1, "Do not include file name, just the root of the URL.");
            // 
            // tbxFileName
            // 
            this.tbxFileName.Location = new System.Drawing.Point(73, 38);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(84, 20);
            this.tbxFileName.TabIndex = 1;
            this.tbxFileName.Text = "file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "File Name:";
            // 
            // cbxExtension
            // 
            this.cbxExtension.FormattingEnabled = true;
            this.cbxExtension.Items.AddRange(new object[] {
            ".zip",
            ".7z",
            ".rar"});
            this.cbxExtension.Location = new System.Drawing.Point(350, 38);
            this.cbxExtension.Name = "cbxExtension";
            this.cbxExtension.Size = new System.Drawing.Size(51, 21);
            this.cbxExtension.TabIndex = 2;
            this.cbxExtension.Text = ".zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Extension:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 209);
            this.Controls.Add(this.cbxExtension);
            this.Controls.Add(this.lblBytes);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxFileName);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.btnDstPicker);
            this.Controls.Add(this.tbxDstPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Client Downloader v1.0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxDstPath;
        private System.Windows.Forms.Button btnDstPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox cbxIgnoreMsgs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblBytes;
        private System.Windows.Forms.CheckBox cbxOpenDst;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox tbxFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxExtension;
        private System.Windows.Forms.Label label6;
    }
}

