using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Structure_helper
{
    public partial class JobStructures : Form
    {
        public JobStructures()
        {
            InitializeComponent();
            this.Text = "Job " + Program.CurrentJob.JobNumber;
            this.lstbx_Structures.DataSource = Program.CurrentJob.Structures;
            this.lstbx_Structures.DisplayMember = "Shot";
            this.btn_EditStructure.Enabled = false;
            this.btn_EditPipes.Enabled = false;
        }

        private void btn_AddStructure_Click(object sender, EventArgs e)
        {
            Structure structure = new Structure();
            Program.CurrentJob.Structures.Add(structure);
            this.Hide();
            EnterStructInfo enterStructInfo = new EnterStructInfo(structure);
            enterStructInfo.Parent = this;
            enterStructInfo.ShowDialog();
        }

        private void JobStructures_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Program.StartScrn.Show();
        }

        public ListBox StructureList
        {
            get { return lstbx_Structures; }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //create new text file to save current data - always overwrites old 
            string fileName = Program.CurrentJob.JobNumber + ".shs";
            using (StreamWriter writer = new StreamWriter(fileName,false))
            {
                foreach (Structure sc in CurrentJob.Structures)
                {
                    string s = String.Format("{0},{1},{2},{3}", sc.Shot, sc.Label, sc.Type.ToString(), sc.Pipes.Count.ToString());
                    writer.WriteLine(s);

                    foreach (PipeEnd p in sc.Pipes)
                    {
                        s = string.Format("{0},{1},{2},{3},{4}", p.Invert.ToString(),p.Flow.ToString(),p.Direction.ToString(), p.Diameter.ToString(), p.Type.ToString());
                        writer.WriteLine(s);
                    }
                }
            }
        }

        private void btn_EditStructure_Click(object sender, EventArgs e)
        {
            Structure structure = (Structure)lstbx_Structures.SelectedItem;
            this.Hide();
            EnterStructInfo enterStructInfo = new EnterStructInfo(structure);
            enterStructInfo.Parent = this;
            enterStructInfo.ShowDialog();
        }

        private void lstbx_Structures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbx_Structures.SelectedIndex == -1)
            {
                btn_EditStructure.Enabled = false;
                btn_EditPipes.Enabled = false;
            }
            else
            {
                btn_EditStructure.Enabled = true;
                btn_EditPipes.Enabled = true;
            }
        }

        private void btn_EditConnections_Click(object sender, EventArgs e)
        {

        }

        public Job CurrentJob
        {
            get { return Program.CurrentJob; }
        }
    }
}
