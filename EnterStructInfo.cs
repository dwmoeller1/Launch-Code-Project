using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Structure_helper
{
    public partial class EnterStructInfo : Form
    {
        Structure structure;
        private bool connecting;

        public EnterStructInfo(Structure structure, bool connecting =false)
        {
            InitializeComponent();
            this.connecting = connecting;
            this.structure = structure;
            this.cmb_StructureType.DataSource = Enum.GetNames(typeof(StructureType));
            this.Text = Program.CurrentJob.JobNumber.ToString();
            txt_Label.Text = structure.Label;
            txt_ShotNumber.Text = structure.Shot.ToString();
            cmb_StructureType.Text = structure.Type.ToString();
            if (connecting)
                btn_EditAddPipes.Visible = false;
            else
                btn_EditAddPipes.Visible = true;
        }

        public new JobStructures Parent { get; set; }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if(this.Parent!=null)
                this.Parent.Show();
            this.Dispose();
        }

        private void EnterStructInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Parent!=null)
                this.Parent.Show();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            SaveInfo();
            if (this.Parent !=null)
            {
                this.Parent.StructureList.DataSource = null;
                this.Parent.StructureList.DataSource = Program.CurrentJob.Structures;
                this.Parent.StructureList.DisplayMember = "Shot";
                this.Parent.Show();
            }
            this.Dispose();  
        }

        private void btn_CaptureCoords_Click(object sender, EventArgs e)
        {
            //to be implemented
        }

        private void btn_AddEditPipes_Click(object sender, EventArgs e)
        {
            SaveInfo();
            StructurePipes pipeList = new StructurePipes(structure);
            pipeList.Parent = this;
            this.Hide();
            pipeList.Show();
            pipeList.DrawStructure();
        }

        void SaveInfo()
        {
            structure.Label = txt_Label.Text.ToString();
            structure.Shot = txt_ShotNumber.Text.ToString();
            structure.Type = (StructureType)Enum.Parse(typeof(StructureType), cmb_StructureType.Text);
        }
    }
}
