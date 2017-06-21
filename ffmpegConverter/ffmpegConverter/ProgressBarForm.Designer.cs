namespace ffmpegConverter
{
    partial class ProgressBarForm
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
            this.ProgressRateLabel = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ProgressRateLabel
            // 
            this.ProgressRateLabel.Location = new System.Drawing.Point(9, 72);
            this.ProgressRateLabel.Name = "ProgressRateLabel";
            this.ProgressRateLabel.Size = new System.Drawing.Size(254, 23);
            this.ProgressRateLabel.TabIndex = 8;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(272, 69);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(86, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Location = new System.Drawing.Point(9, 10);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(349, 23);
            this.FileNameLabel.TabIndex = 6;
            // 
            // FileProgressBar
            // 
            this.FileProgressBar.Location = new System.Drawing.Point(12, 36);
            this.FileProgressBar.Name = "FileProgressBar";
            this.FileProgressBar.Size = new System.Drawing.Size(346, 23);
            this.FileProgressBar.TabIndex = 5;
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 107);
            this.Controls.Add(this.ProgressRateLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileProgressBar);
            this.Name = "ProgressBarForm";
            this.Text = "Processing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ProgressRateLabel;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.ProgressBar FileProgressBar;
    }
}