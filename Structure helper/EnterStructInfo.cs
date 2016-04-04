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
        public EnterStructInfo(Structure structure)
        {
            InitializeComponent();
            this.structure = structure;
            this.cmb_StructureType.DataSource = Enum.GetNames(typeof(StructureType));
            this.Text = Program.CurrentJob.JobNumber.ToString();
            txt_Label.Text = structure.Label;
            txt_ShotNumber.Text = structure.Shot.ToString();
        }

        public new JobStructures Parent { get; set; }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Parent.Show();
        }

        private void EnterStructInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {            
            structure.Label = txt_Label.Text.ToString();
            structure.Shot = txt_ShotNumber.Text.ToString();
            string s = cmb_StructureType.SelectedValue.ToString();
            structure.Type = (StructureType)Enum.Parse(typeof(StructureType), s);              
        }

        private void btn_SaveExit_Click(object sender, EventArgs e)
        {
            structure.Label = txt_Label.Text.ToString();
            structure.Shot = txt_ShotNumber.Text.ToString();            
            string s = cmb_StructureType.SelectedValue.ToString();
            structure.Type = (StructureType)Enum.Parse(typeof(StructureType), s);            
            this.Parent.StructureList.DataSource = null;
            this.Parent.StructureList.DataSource = Program.CurrentJob.Structures;
            this.Parent.StructureList.DisplayMember = "Shot";
            this.Parent.Show();
            this.Dispose();  
        }

        private void btn_CaptureCoords_Click(object sender, EventArgs e)
        {
            //to be implemented
        }

        private void btn_EditAddPipes_Click(object sender, EventArgs e)
        {
            StructurePipes pipeList = new StructurePipes(structure);
            pipeList.Parent = this;
            this.Hide();
            pipeList.Show();
            pipeList.DrawStructure();
        }
    }
}
