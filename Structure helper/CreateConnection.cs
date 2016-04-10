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
    public partial class CreateConnection : Form
    {
        public Structure SelectedStructure { get; set; }
        public PipeEnd SelectedPipe { get; set; }
        public PipeEnd pipe;

        public CreateConnection(PipeEnd pipe)
        {
            InitializeComponent();
            this.pipe = pipe;
            lst_Structures.DataSource = Program.CurrentJob.Structures;
            lst_Structures.DisplayMember = "Shot";
            btn_Connect.Enabled = false;
            lst_Structures.SelectedIndex = -1;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            this.SelectedStructure = (Structure)lst_Structures.SelectedItem;
            StructurePipes pipes = new StructurePipes(this.SelectedStructure,true);
            if (pipes.ShowDialog() == DialogResult.OK)
            {
                this.SelectedPipe = (PipeEnd)pipes.PipeList.SelectedItem;
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }

        private void lst_Structures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Structures.SelectedItem != pipe.ParentStructure && lst_Structures.SelectedIndex != -1)
                btn_Connect.Enabled = true;
            else
                btn_Connect.Enabled = false;
        }
    }
}
