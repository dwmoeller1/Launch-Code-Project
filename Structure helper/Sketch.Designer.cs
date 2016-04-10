namespace Structure_helper
{
    partial class Sketch
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
            this.sketchArea = new System.Windows.Forms.PictureBox();
            this.btn_ShowConnections = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sketchArea)).BeginInit();
            this.SuspendLayout();
            // 
            // sketchArea
            // 
            this.sketchArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sketchArea.BackColor = System.Drawing.SystemColors.Window;
            this.sketchArea.Location = new System.Drawing.Point(29, 23);
            this.sketchArea.Name = "sketchArea";
            this.sketchArea.Size = new System.Drawing.Size(1140, 569);
            this.sketchArea.TabIndex = 0;
            this.sketchArea.TabStop = false;
            this.sketchArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sketchArea_MouseClick);
            this.sketchArea.Resize += new System.EventHandler(this.sketchArea_Resize);
            // 
            // btn_ShowConnections
            // 
            this.btn_ShowConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ShowConnections.Location = new System.Drawing.Point(1191, 43);
            this.btn_ShowConnections.Name = "btn_ShowConnections";
            this.btn_ShowConnections.Size = new System.Drawing.Size(75, 42);
            this.btn_ShowConnections.TabIndex = 1;
            this.btn_ShowConnections.Text = "Show Connections";
            this.btn_ShowConnections.UseVisualStyleBackColor = true;
            this.btn_ShowConnections.Click += new System.EventHandler(this.btn_ShowConnections_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1191, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Sketch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 623);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ShowConnections);
            this.Controls.Add(this.sketchArea);
            this.MinimumSize = new System.Drawing.Size(1294, 659);
            this.Name = "Sketch";
            this.Text = "Sketch";
            ((System.ComponentModel.ISupportInitialize)(this.sketchArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sketchArea;
        private System.Windows.Forms.Button btn_ShowConnections;
        private System.Windows.Forms.Button button2;


    }
}