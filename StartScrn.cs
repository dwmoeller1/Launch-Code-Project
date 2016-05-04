using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Deployment.Application;

namespace Structure_helper
{
    public partial class StartScrn : Form
    {
        public StartScrn()
        {
            InitializeComponent();
            Program.StartScrn = this;
            Program.Connections = new Connections();

            //label1.Text = "version " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            label1.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void btn_NewJob_Click(object sender, EventArgs e)
        {
            EnterJobNum enterJobNum = new EnterJobNum();
            this.Hide();
            enterJobNum.ShowDialog();            
        }

        private void btn_EditJob_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.LoadFile(openFileDialog1.FileName);

                this.Hide();
                (new JobStructures()).Show();

            }
        }

        private void btn_UploadShotFile_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = Application.StartupPath;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                File.LoadShotFile(openFileDialog2.FileName);
                this.Hide();
                (new JobStructures()).Show();

            }
        }

        private void btn_Merge_Click(object sender, EventArgs e)
        {
            if ((new Merge()).ShowDialog() == DialogResult.OK)
            {                
                this.Hide();
                (new JobStructures()).Show();
            }
            
        }
    }
}
