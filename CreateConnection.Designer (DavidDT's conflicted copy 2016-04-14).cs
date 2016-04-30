namespace Structure_helper
{
    partial class CreateConnection
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
            this.lst_Structures = new System.Windows.Forms.ListBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Structures
            // 
            this.lst_Structures.FormattingEnabled = true;
            this.lst_Structures.Location = new System.Drawing.Point(297, 24);
            this.lst_Structures.Name = "lst_Structures";
            this.lst_Structures.Size = new System.Drawing.Size(120, 225);
            this.lst_Structures.TabIndex = 0;
            this.lst_Structures.SelectedIndexChanged += new System.EventHandler(this.lst_Structures_SelectedIndexChanged);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(175, 86);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(102, 30);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Make Connection";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // CreateConnection
            // 
            this.AcceptButton = this.btn_Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 293);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.lst_Structures);
            this.Name = "CreateConnection";
            this.Text = "Create a Connection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Structures;
        private System.Windows.Forms.Button btn_Connect;
    }
}