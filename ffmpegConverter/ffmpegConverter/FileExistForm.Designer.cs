namespace ffmpegConverter
{
    partial class FileExistForm
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
            this.pathlb = new System.Windows.Forms.Label();
            this.replacebtn = new System.Windows.Forms.Button();
            this.skipbtn = new System.Windows.Forms.Button();
            this.replaceallbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathlb
            // 
            this.pathlb.Location = new System.Drawing.Point(13, 13);
            this.pathlb.Name = "pathlb";
            this.pathlb.Size = new System.Drawing.Size(342, 23);
            this.pathlb.TabIndex = 0;
            // 
            // replacebtn
            // 
            this.replacebtn.Location = new System.Drawing.Point(13, 61);
            this.replacebtn.Name = "replacebtn";
            this.replacebtn.Size = new System.Drawing.Size(110, 34);
            this.replacebtn.TabIndex = 1;
            this.replacebtn.Text = "Replace";
            this.replacebtn.UseVisualStyleBackColor = true;
            // 
            // skipbtn
            // 
            this.skipbtn.Location = new System.Drawing.Point(129, 61);
            this.skipbtn.Name = "skipbtn";
            this.skipbtn.Size = new System.Drawing.Size(110, 34);
            this.skipbtn.TabIndex = 1;
            this.skipbtn.Text = "Skip";
            this.skipbtn.UseVisualStyleBackColor = true;
            // 
            // replaceallbtn
            // 
            this.replaceallbtn.Location = new System.Drawing.Point(245, 61);
            this.replaceallbtn.Name = "replaceallbtn";
            this.replaceallbtn.Size = new System.Drawing.Size(110, 34);
            this.replaceallbtn.TabIndex = 1;
            this.replaceallbtn.Text = "ReplaceAll";
            this.replaceallbtn.UseVisualStyleBackColor = true;
            // 
            // FileExistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 107);
            this.Controls.Add(this.replaceallbtn);
            this.Controls.Add(this.skipbtn);
            this.Controls.Add(this.replacebtn);
            this.Controls.Add(this.pathlb);
            this.Name = "FileExistForm";
            this.Text = "Your file is exist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pathlb;
        private System.Windows.Forms.Button replacebtn;
        private System.Windows.Forms.Button skipbtn;
        private System.Windows.Forms.Button replaceallbtn;
    }
}