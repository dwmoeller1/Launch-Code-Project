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
    public partial class StartScrn : Form
    {
        public StartScrn()
        {
            InitializeComponent();
            Program.StartScrn = this;
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
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    string[] arr = openFileDialog1.FileName.Split('.');
                    Program.CurrentJob = new Job(arr[0]);
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Structure sc = new Structure();
                        Program.CurrentJob.Structures.Add(sc);

                        arr =  line.Split(',');
                        sc.Shot = arr[0];
                        sc.Label = arr[1];
                        sc.Type = (StructureType)Enum.Parse(typeof(StructureType), arr[2]);
                        int n = Convert.ToInt32(arr[3]);

                        for (int i = 0; i < n; i++)
                        {
                            PipeEnd p = new PipeEnd(sc);
                            sc.Pipes.Add(p);
                            line = reader.ReadLine();
                            arr = line.Split(',');

                            p.ID = ((char)(sc.Pipes.Count-1 + 'A')).ToString();
                            p.Invert = float.Parse(arr[0]);
                            p.Flow = (Flow)Enum.Parse(typeof(Flow), arr[1]);
                            p.Direction = float.Parse(arr[2]);
                            p.Diameter = float.Parse(arr[3]);
                            p.Type = (PipeType)Enum.Parse(typeof(PipeType), arr[4]);
                        }
                    }

                    this.Hide();
                    (new JobStructures()).Show();
                }
            }
        }
    }
}
