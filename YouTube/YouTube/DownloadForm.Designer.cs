namespace YouTube
{
    partial class DownloadForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.影片搜尋器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.urlRadio = new System.Windows.Forms.RadioButton();
            this.idRadio = new System.Windows.Forms.RadioButton();
            this.inpGroup = new System.Windows.Forms.GroupBox();
            this.outGroup = new System.Windows.Forms.GroupBox();
            this.useTitleAsNameBox = new System.Windows.Forms.CheckBox();
            this.bestCheck = new System.Windows.Forms.CheckBox();
            this.quaLabel = new System.Windows.Forms.Label();
            this.bitrateLabel = new System.Windows.Forms.Label();
            this.quaBox = new System.Windows.Forms.ComboBox();
            this.bitrateBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formatBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selOutButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.startButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.inpGroup.SuspendLayout();
            this.outGroup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.結束ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.影片搜尋器ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 影片搜尋器ToolStripMenuItem
            // 
            this.影片搜尋器ToolStripMenuItem.Name = "影片搜尋器ToolStripMenuItem";
            this.影片搜尋器ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.影片搜尋器ToolStripMenuItem.Text = "影片搜尋器";
            this.影片搜尋器ToolStripMenuItem.Click += new System.EventHandler(this.影片搜尋器ToolStripMenuItem_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(71, 25);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(409, 22);
            this.inputBox.TabIndex = 1;
            // 
            // urlRadio
            // 
            this.urlRadio.AutoSize = true;
            this.urlRadio.Location = new System.Drawing.Point(6, 20);
            this.urlRadio.Name = "urlRadio";
            this.urlRadio.Size = new System.Drawing.Size(47, 16);
            this.urlRadio.TabIndex = 2;
            this.urlRadio.TabStop = true;
            this.urlRadio.Text = "網址";
            this.urlRadio.UseVisualStyleBackColor = true;
            // 
            // idRadio
            // 
            this.idRadio.AutoSize = true;
            this.idRadio.Location = new System.Drawing.Point(6, 42);
            this.idRadio.Name = "idRadio";
            this.idRadio.Size = new System.Drawing.Size(59, 16);
            this.idRadio.TabIndex = 2;
            this.idRadio.TabStop = true;
            this.idRadio.Text = "影片ID";
            this.idRadio.UseVisualStyleBackColor = true;
            // 
            // inpGroup
            // 
            this.inpGroup.Controls.Add(this.inputBox);
            this.inpGroup.Controls.Add(this.idRadio);
            this.inpGroup.Controls.Add(this.urlRadio);
            this.inpGroup.Location = new System.Drawing.Point(12, 27);
            this.inpGroup.Name = "inpGroup";
            this.inpGroup.Size = new System.Drawing.Size(486, 64);
            this.inpGroup.TabIndex = 3;
            this.inpGroup.TabStop = false;
            this.inpGroup.Text = "輸入";
            // 
            // outGroup
            // 
            this.outGroup.Controls.Add(this.useTitleAsNameBox);
            this.outGroup.Controls.Add(this.bestCheck);
            this.outGroup.Controls.Add(this.quaLabel);
            this.outGroup.Controls.Add(this.bitrateLabel);
            this.outGroup.Controls.Add(this.quaBox);
            this.outGroup.Controls.Add(this.bitrateBox);
            this.outGroup.Controls.Add(this.label2);
            this.outGroup.Controls.Add(this.formatBox);
            this.outGroup.Controls.Add(this.label1);
            this.outGroup.Controls.Add(this.selOutButton);
            this.outGroup.Controls.Add(this.outputBox);
            this.outGroup.Location = new System.Drawing.Point(12, 97);
            this.outGroup.Name = "outGroup";
            this.outGroup.Size = new System.Drawing.Size(486, 109);
            this.outGroup.TabIndex = 4;
            this.outGroup.TabStop = false;
            this.outGroup.Text = "輸出";
            // 
            // useTitleAsNameBox
            // 
            this.useTitleAsNameBox.AutoSize = true;
            this.useTitleAsNameBox.Location = new System.Drawing.Point(348, 50);
            this.useTitleAsNameBox.Name = "useTitleAsNameBox";
            this.useTitleAsNameBox.Size = new System.Drawing.Size(132, 16);
            this.useTitleAsNameBox.TabIndex = 10;
            this.useTitleAsNameBox.Text = "使用影片標題為檔名";
            this.useTitleAsNameBox.UseVisualStyleBackColor = true;
            this.useTitleAsNameBox.CheckedChanged += new System.EventHandler(this.useTitleAsNameBox_CheckedChanged);
            // 
            // bestCheck
            // 
            this.bestCheck.AutoSize = true;
            this.bestCheck.Location = new System.Drawing.Point(142, 78);
            this.bestCheck.Name = "bestCheck";
            this.bestCheck.Size = new System.Drawing.Size(48, 16);
            this.bestCheck.TabIndex = 9;
            this.bestCheck.Text = "最高";
            this.bestCheck.UseVisualStyleBackColor = true;
            this.bestCheck.Visible = false;
            this.bestCheck.CheckedChanged += new System.EventHandler(this.bestBitrateCheck_CheckedChanged);
            // 
            // quaLabel
            // 
            this.quaLabel.AutoSize = true;
            this.quaLabel.Location = new System.Drawing.Point(9, 79);
            this.quaLabel.Name = "quaLabel";
            this.quaLabel.Size = new System.Drawing.Size(32, 12);
            this.quaLabel.TabIndex = 8;
            this.quaLabel.Text = "品質:";
            this.quaLabel.Visible = false;
            // 
            // bitrateLabel
            // 
            this.bitrateLabel.AutoSize = true;
            this.bitrateLabel.Location = new System.Drawing.Point(9, 80);
            this.bitrateLabel.Name = "bitrateLabel";
            this.bitrateLabel.Size = new System.Drawing.Size(44, 12);
            this.bitrateLabel.TabIndex = 8;
            this.bitrateLabel.Text = "位元率:";
            this.bitrateLabel.Visible = false;
            // 
            // quaBox
            // 
            this.quaBox.FormattingEnabled = true;
            this.quaBox.Items.AddRange(new object[] {
            "360p",
            "480p",
            "720p",
            "1080p"});
            this.quaBox.Location = new System.Drawing.Point(71, 75);
            this.quaBox.Name = "quaBox";
            this.quaBox.Size = new System.Drawing.Size(65, 20);
            this.quaBox.TabIndex = 7;
            this.quaBox.Visible = false;
            // 
            // bitrateBox
            // 
            this.bitrateBox.FormattingEnabled = true;
            this.bitrateBox.Items.AddRange(new object[] {
            "128k",
            "192k",
            "256k",
            "320k"});
            this.bitrateBox.Location = new System.Drawing.Point(71, 75);
            this.bitrateBox.Name = "bitrateBox";
            this.bitrateBox.Size = new System.Drawing.Size(65, 20);
            this.bitrateBox.TabIndex = 7;
            this.bitrateBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "檔案格式: ";
            // 
            // formatBox
            // 
            this.formatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatBox.FormattingEnabled = true;
            this.formatBox.Items.AddRange(new object[] {
            "Mp3",
            "Mp4"});
            this.formatBox.Location = new System.Drawing.Point(71, 49);
            this.formatBox.Name = "formatBox";
            this.formatBox.Size = new System.Drawing.Size(65, 20);
            this.formatBox.TabIndex = 5;
            this.formatBox.SelectedIndexChanged += new System.EventHandler(this.formatBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "輸出檔案:";
            // 
            // selOutButton
            // 
            this.selOutButton.Location = new System.Drawing.Point(457, 20);
            this.selOutButton.Name = "selOutButton";
            this.selOutButton.Size = new System.Drawing.Size(23, 23);
            this.selOutButton.TabIndex = 1;
            this.selOutButton.Text = "...";
            this.selOutButton.UseVisualStyleBackColor = true;
            this.selOutButton.Click += new System.EventHandler(this.selOutButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(71, 21);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(380, 22);
            this.outputBox.TabIndex = 0;
            // 
            // sfd
            // 
            this.sfd.Filter = "MP3 (*.mp3)|*.mp3|MP4 (*.mp4)|*.mp4|所有檔案 (*.*)|*.*";
            this.sfd.Title = "另存新檔";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 212);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(486, 49);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "開始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLabel,
            this.toolStripStatusLabel2,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(510, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statLabel
            // 
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(31, 17);
            this.statLabel.Text = "就緒";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(312, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // progressBar
            // 
            this.progressBar.Enabled = false;
            this.progressBar.MarqueeAnimationSpeed = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(150, 16);
            this.progressBar.Step = 20;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 490);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outGroup);
            this.Controls.Add(this.inpGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DownloadForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.inpGroup.ResumeLayout(false);
            this.inpGroup.PerformLayout();
            this.outGroup.ResumeLayout(false);
            this.outGroup.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 影片搜尋器ToolStripMenuItem;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.RadioButton urlRadio;
        private System.Windows.Forms.RadioButton idRadio;
        private System.Windows.Forms.GroupBox inpGroup;
        private System.Windows.Forms.GroupBox outGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selOutButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox formatBox;
        private System.Windows.Forms.Label bitrateLabel;
        private System.Windows.Forms.ComboBox bitrateBox;
        private System.Windows.Forms.Label quaLabel;
        private System.Windows.Forms.ComboBox quaBox;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.CheckBox bestCheck;
        private System.Windows.Forms.CheckBox useTitleAsNameBox;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripProgressBar progressBar;
    }
}

