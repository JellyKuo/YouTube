namespace YouTube
{
    partial class MainForm
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
            this.wb = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripFillLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PopupPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.PopupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb
            // 
            this.wb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wb.Location = new System.Drawing.Point(0, 54);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(984, 885);
            this.wb.TabIndex = 0;
            this.wb.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wb_Navigated);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(94, 26);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(856, 22);
            this.urlBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "網址:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(5, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(34, 26);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(23, 23);
            this.forwardButton.TabIndex = 4;
            this.forwardButton.Text = "→";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.LimeGreen;
            this.goButton.Location = new System.Drawing.Point(956, 26);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(23, 23);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "→";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.Go);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLabel,
            this.toolStripFillLabel,
            this.ProgBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 939);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgBar
            // 
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.Size = new System.Drawing.Size(150, 16);
            // 
            // toolStripFillLabel
            // 
            this.toolStripFillLabel.Name = "toolStripFillLabel";
            this.toolStripFillLabel.Size = new System.Drawing.Size(689, 17);
            this.toolStripFillLabel.Spring = true;
            // 
            // statLabel
            // 
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(128, 17);
            this.statLabel.Text = "toolStripStatusLabel1";
            // 
            // PopupPanel
            // 
            this.PopupPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PopupPanel.Controls.Add(this.button1);
            this.PopupPanel.Location = new System.Drawing.Point(729, 54);
            this.PopupPanel.Name = "PopupPanel";
            this.PopupPanel.Size = new System.Drawing.Size(238, 100);
            this.PopupPanel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.PopupPanel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.PopupPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgBar;
        private System.Windows.Forms.ToolStripStatusLabel statLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFillLabel;
        private System.Windows.Forms.Panel PopupPanel;
        private System.Windows.Forms.Button button1;
    }
}

