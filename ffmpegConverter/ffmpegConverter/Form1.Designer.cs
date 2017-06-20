namespace ffmpegConverter
{
    partial class Form1
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
            this.filelistBox = new System.Windows.Forms.ListBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.FormatBox = new System.Windows.Forms.ComboBox();
            this.AutoConvertBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.OuputPathbtn = new System.Windows.Forms.Button();
            this.OutputPathBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // filelistBox
            // 
            this.filelistBox.FormattingEnabled = true;
            this.filelistBox.ItemHeight = 16;
            this.filelistBox.Location = new System.Drawing.Point(13, 13);
            this.filelistBox.Name = "filelistBox";
            this.filelistBox.Size = new System.Drawing.Size(557, 420);
            this.filelistBox.TabIndex = 0;
            this.filelistBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilelistBox_DragDrop);
            this.filelistBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FilelistBox_DragEnter);
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(12, 510);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(276, 31);
            this.InputButton.TabIndex = 1;
            this.InputButton.Text = "button1";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(294, 510);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(276, 31);
            this.ConvertButton.TabIndex = 1;
            this.ConvertButton.Text = "button1";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // FormatBox
            // 
            this.FormatBox.FormattingEnabled = true;
            this.FormatBox.Items.AddRange(new object[] {
            ".mp3",
            ".m4a"});
            this.FormatBox.Location = new System.Drawing.Point(13, 439);
            this.FormatBox.Name = "FormatBox";
            this.FormatBox.Size = new System.Drawing.Size(121, 24);
            this.FormatBox.TabIndex = 2;
            // 
            // AutoConvertBox
            // 
            this.AutoConvertBox.AutoSize = true;
            this.AutoConvertBox.Location = new System.Drawing.Point(12, 470);
            this.AutoConvertBox.Name = "AutoConvertBox";
            this.AutoConvertBox.Size = new System.Drawing.Size(108, 21);
            this.AutoConvertBox.TabIndex = 3;
            this.AutoConvertBox.Text = "AutoConvert";
            this.AutoConvertBox.UseVisualStyleBackColor = true;
            this.AutoConvertBox.CheckedChanged += new System.EventHandler(this.AutoConvertBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // OuputPathbtn
            // 
            this.OuputPathbtn.Location = new System.Drawing.Point(520, 438);
            this.OuputPathbtn.Name = "OuputPathbtn";
            this.OuputPathbtn.Size = new System.Drawing.Size(50, 25);
            this.OuputPathbtn.TabIndex = 5;
            this.OuputPathbtn.Text = "...";
            this.OuputPathbtn.UseVisualStyleBackColor = true;
            this.OuputPathbtn.Click += new System.EventHandler(this.OuputPathbtn_Click);
            // 
            // OutputPathBox
            // 
            this.OutputPathBox.Location = new System.Drawing.Point(140, 439);
            this.OutputPathBox.Name = "OutputPathBox";
            this.OutputPathBox.Size = new System.Drawing.Size(374, 22);
            this.OutputPathBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.OutputPathBox);
            this.Controls.Add(this.OuputPathbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutoConvertBox);
            this.Controls.Add(this.FormatBox);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.filelistBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox filelistBox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.ComboBox FormatBox;
        private System.Windows.Forms.CheckBox AutoConvertBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OuputPathbtn;
        private System.Windows.Forms.TextBox OutputPathBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

