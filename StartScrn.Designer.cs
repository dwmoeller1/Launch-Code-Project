namespace Structure_helper
{
    partial class StartScrn
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
            this.btn_NewJob = new System.Windows.Forms.Button();
            this.btn_EditJob = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_UploadShotFile = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Merge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewJob
            // 
            this.btn_NewJob.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_NewJob.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewJob.Location = new System.Drawing.Point(69, 57);
            this.btn_NewJob.Name = "btn_NewJob";
            this.btn_NewJob.Size = new System.Drawing.Size(143, 62);
            this.btn_NewJob.TabIndex = 0;
            this.btn_NewJob.Text = "Start New Job";
            this.btn_NewJob.UseVisualStyleBackColor = false;
            this.btn_NewJob.Click += new System.EventHandler(this.btn_NewJob_Click);
            // 
            // btn_EditJob
            // 
            this.btn_EditJob.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_EditJob.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditJob.Location = new System.Drawing.Point(69, 137);
            this.btn_EditJob.Name = "btn_EditJob";
            this.btn_EditJob.Size = new System.Drawing.Size(143, 62);
            this.btn_EditJob.TabIndex = 1;
            this.btn_EditJob.Text = "Edit Existing Job";
            this.btn_EditJob.UseVisualStyleBackColor = false;
            this.btn_EditJob.Click += new System.EventHandler(this.btn_EditJob_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Structure Helper save|*.shs|Text files|*.txt|All files|*.*";
            // 
            // btn_UploadShotFile
            // 
            this.btn_UploadShotFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_UploadShotFile.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UploadShotFile.Location = new System.Drawing.Point(69, 217);
            this.btn_UploadShotFile.Name = "btn_UploadShotFile";
            this.btn_UploadShotFile.Size = new System.Drawing.Size(143, 62);
            this.btn_UploadShotFile.TabIndex = 2;
            this.btn_UploadShotFile.Text = "Upload Shot File";
            this.btn_UploadShotFile.UseVisualStyleBackColor = false;
            this.btn_UploadShotFile.Click += new System.EventHandler(this.btn_UploadShotFile_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Text Files |*.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btn_Merge
            // 
            this.btn_Merge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Merge.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Merge.Location = new System.Drawing.Point(69, 301);
            this.btn_Merge.Name = "btn_Merge";
            this.btn_Merge.Size = new System.Drawing.Size(143, 62);
            this.btn_Merge.TabIndex = 4;
            this.btn_Merge.Text = "Merge Shot File and Existing Job";
            this.btn_Merge.UseVisualStyleBackColor = false;
            this.btn_Merge.Click += new System.EventHandler(this.btn_Merge_Click);
            // 
            // StartScrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 375);
            this.Controls.Add(this.btn_Merge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_UploadShotFile);
            this.Controls.Add(this.btn_EditJob);
            this.Controls.Add(this.btn_NewJob);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartScrn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Structure Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewJob;
        private System.Windows.Forms.Button btn_EditJob;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_UploadShotFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Merge;
    }
}