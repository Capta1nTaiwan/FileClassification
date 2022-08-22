namespace File_Classify_Date
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectPathBtn = new System.Windows.Forms.Button();
            this.DoClassifyBtn = new System.Windows.Forms.Button();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SelectPathBtn
            // 
            this.SelectPathBtn.Location = new System.Drawing.Point(37, 34);
            this.SelectPathBtn.Name = "SelectPathBtn";
            this.SelectPathBtn.Size = new System.Drawing.Size(152, 43);
            this.SelectPathBtn.TabIndex = 1;
            this.SelectPathBtn.Text = "選擇路徑";
            this.SelectPathBtn.UseVisualStyleBackColor = true;
            this.SelectPathBtn.Click += new System.EventHandler(this.SelectPathBtn_Click);
            // 
            // DoClassifyBtn
            // 
            this.DoClassifyBtn.Location = new System.Drawing.Point(37, 174);
            this.DoClassifyBtn.Name = "DoClassifyBtn";
            this.DoClassifyBtn.Size = new System.Drawing.Size(152, 43);
            this.DoClassifyBtn.TabIndex = 2;
            this.DoClassifyBtn.Text = "執行分類";
            this.DoClassifyBtn.UseVisualStyleBackColor = true;
            this.DoClassifyBtn.Click += new System.EventHandler(this.DoClassifyBtn_Click);
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(37, 105);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(369, 33);
            this.tbxPath.TabIndex = 3;
            this.tbxPath.Text = "可將路徑複製於此";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 229);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.DoClassifyBtn);
            this.Controls.Add(this.SelectPathBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button SelectPathBtn;
        private System.Windows.Forms.Button DoClassifyBtn;
        private System.Windows.Forms.TextBox tbxPath;
    }
}

