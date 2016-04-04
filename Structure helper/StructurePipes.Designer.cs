namespace Structure_helper
{
    partial class StructurePipes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Done = new System.Windows.Forms.Button();
            this.btn_EditPipe = new System.Windows.Forms.Button();
            this.btn_AddPipe = new System.Windows.Forms.Button();
            this.lstbx_Pipes = new System.Windows.Forms.ListBox();
            this.sketchArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pipes";
            // 
            // btn_Done
            // 
            this.btn_Done.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Done.Location = new System.Drawing.Point(122, 353);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(75, 23);
            this.btn_Done.TabIndex = 8;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // btn_EditPipe
            // 
            this.btn_EditPipe.Location = new System.Drawing.Point(153, 83);
            this.btn_EditPipe.Name = "btn_EditPipe";
            this.btn_EditPipe.Size = new System.Drawing.Size(75, 23);
            this.btn_EditPipe.TabIndex = 7;
            this.btn_EditPipe.Text = "Edit Pipe";
            this.btn_EditPipe.UseVisualStyleBackColor = true;
            this.btn_EditPipe.Click += new System.EventHandler(this.btn_EditPipe_Click);
            // 
            // btn_AddPipe
            // 
            this.btn_AddPipe.Location = new System.Drawing.Point(153, 43);
            this.btn_AddPipe.Name = "btn_AddPipe";
            this.btn_AddPipe.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPipe.TabIndex = 6;
            this.btn_AddPipe.Text = "Add";
            this.btn_AddPipe.UseVisualStyleBackColor = true;
            this.btn_AddPipe.Click += new System.EventHandler(this.btn_AddPipe_Click);
            // 
            // lstbx_Pipes
            // 
            this.lstbx_Pipes.DisplayMember = "Invert";
            this.lstbx_Pipes.FormattingEnabled = true;
            this.lstbx_Pipes.Location = new System.Drawing.Point(27, 43);
            this.lstbx_Pipes.Name = "lstbx_Pipes";
            this.lstbx_Pipes.Size = new System.Drawing.Size(101, 95);
            this.lstbx_Pipes.TabIndex = 5;
            // 
            // sketchArea
            // 
            this.sketchArea.BackColor = System.Drawing.SystemColors.Window;
            this.sketchArea.Location = new System.Drawing.Point(22, 157);
            this.sketchArea.Name = "sketchArea";
            this.sketchArea.Size = new System.Drawing.Size(276, 187);
            this.sketchArea.TabIndex = 10;
            // 
            // StructurePipes
            // 
            this.AcceptButton = this.btn_Done;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 388);
            this.Controls.Add(this.sketchArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.btn_EditPipe);
            this.Controls.Add(this.btn_AddPipe);
            this.Controls.Add(this.lstbx_Pipes);
            this.Name = "StructurePipes";
            this.Text = "StructurePipes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StructurePipes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.Button btn_EditPipe;
        private System.Windows.Forms.Button btn_AddPipe;
        private System.Windows.Forms.ListBox lstbx_Pipes;
        private System.Windows.Forms.Panel sketchArea;
    }
}