namespace Structure_helper
{
    partial class EnterStructInfo
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
            this.txt_Label = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_StructureType = new System.Windows.Forms.ComboBox();
            this.btn_EditAddPipes = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ShotNumber = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SaveExit = new System.Windows.Forms.Button();
            this.btn_CaptureCoords = new System.Windows.Forms.Button();
            this.txt_Easting = new System.Windows.Forms.TextBox();
            this.txt_Northing = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Label
            // 
            this.txt_Label.Location = new System.Drawing.Point(154, 76);
            this.txt_Label.Name = "txt_Label";
            this.txt_Label.Size = new System.Drawing.Size(100, 20);
            this.txt_Label.TabIndex = 0;
            this.txt_Label.Text = "none";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Structure Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Structure Label";
            // 
            // cmb_StructureType
            // 
            this.cmb_StructureType.DisplayMember = "(none)";
            this.cmb_StructureType.FormattingEnabled = true;
            this.cmb_StructureType.Location = new System.Drawing.Point(154, 108);
            this.cmb_StructureType.Name = "cmb_StructureType";
            this.cmb_StructureType.Size = new System.Drawing.Size(121, 21);
            this.cmb_StructureType.TabIndex = 5;
            // 
            // btn_EditAddPipes
            // 
            this.btn_EditAddPipes.Location = new System.Drawing.Point(168, 238);
            this.btn_EditAddPipes.Name = "btn_EditAddPipes";
            this.btn_EditAddPipes.Size = new System.Drawing.Size(98, 23);
            this.btn_EditAddPipes.TabIndex = 8;
            this.btn_EditAddPipes.Text = "Add/Edit Pipes";
            this.btn_EditAddPipes.UseVisualStyleBackColor = true;
            this.btn_EditAddPipes.Click += new System.EventHandler(this.btn_EditAddPipes_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(43, 238);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(98, 23);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shot #";
            // 
            // txt_ShotNumber
            // 
            this.txt_ShotNumber.Location = new System.Drawing.Point(154, 36);
            this.txt_ShotNumber.Name = "txt_ShotNumber";
            this.txt_ShotNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_ShotNumber.TabIndex = 10;
            this.txt_ShotNumber.Text = "none";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(168, 285);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(98, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SaveExit
            // 
            this.btn_SaveExit.Location = new System.Drawing.Point(43, 285);
            this.btn_SaveExit.Name = "btn_SaveExit";
            this.btn_SaveExit.Size = new System.Drawing.Size(98, 23);
            this.btn_SaveExit.TabIndex = 12;
            this.btn_SaveExit.Text = "Save and Exit";
            this.btn_SaveExit.UseVisualStyleBackColor = true;
            this.btn_SaveExit.Click += new System.EventHandler(this.btn_SaveExit_Click);
            // 
            // btn_CaptureCoords
            // 
            this.btn_CaptureCoords.Location = new System.Drawing.Point(143, 191);
            this.btn_CaptureCoords.Name = "btn_CaptureCoords";
            this.btn_CaptureCoords.Size = new System.Drawing.Size(98, 23);
            this.btn_CaptureCoords.TabIndex = 13;
            this.btn_CaptureCoords.Text = "Capture Coords";
            this.btn_CaptureCoords.UseVisualStyleBackColor = true;
            this.btn_CaptureCoords.Click += new System.EventHandler(this.btn_CaptureCoords_Click);
            // 
            // txt_Easting
            // 
            this.txt_Easting.Location = new System.Drawing.Point(37, 178);
            this.txt_Easting.Name = "txt_Easting";
            this.txt_Easting.ReadOnly = true;
            this.txt_Easting.Size = new System.Drawing.Size(100, 20);
            this.txt_Easting.TabIndex = 14;
            // 
            // txt_Northing
            // 
            this.txt_Northing.Location = new System.Drawing.Point(37, 204);
            this.txt_Northing.Name = "txt_Northing";
            this.txt_Northing.ReadOnly = true;
            this.txt_Northing.Size = new System.Drawing.Size(100, 20);
            this.txt_Northing.TabIndex = 15;
            // 
            // EnterStructInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(308, 331);
            this.Controls.Add(this.txt_Northing);
            this.Controls.Add(this.txt_Easting);
            this.Controls.Add(this.btn_CaptureCoords);
            this.Controls.Add(this.btn_SaveExit);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_ShotNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_EditAddPipes);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_StructureType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterStructInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Structure Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterStructInfo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_StructureType;
        private System.Windows.Forms.Button btn_EditAddPipes;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ShotNumber;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_SaveExit;
        private System.Windows.Forms.Button btn_CaptureCoords;
        private System.Windows.Forms.TextBox txt_Easting;
        private System.Windows.Forms.TextBox txt_Northing;
    }
}

