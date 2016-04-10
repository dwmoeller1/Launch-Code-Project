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
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    string[] arr = openFileDialog1.FileName.Split('.');
                    Program.CurrentJob = new Job(Path.GetFileNameWithoutExtension(openFileDialog1.FileName));
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == "***")
                            break;

                        Structure sc = new Structure();
                        Program.CurrentJob.Structures.Add(sc);

                        arr =  line.Split(',');
                        sc.Shot = arr[0];
                        sc.Label = arr[1];
                        sc.Type = (StructureType)Enum.Parse(typeof(StructureType), arr[2]);
                        sc.Northing = float.Parse(arr[3]);
                        sc.Easting = float.Parse(arr[4]);
                        sc.Elevation = float.Parse(arr[5]);
                        int n = Convert.ToInt32(arr[6]);

                        for (int i = 0; i < n; i++)
                        {
                            PipeEnd p = new PipeEnd(sc);
                            sc.Pipes.Add(p);
                            line = reader.ReadLine();
                            arr = line.Split(',');

                            p.ID = ((char)(i + 'A')).ToString();
                            p.Invert = float.Parse(arr[0]);
                            p.Flow = (Flow)Enum.Parse(typeof(Flow), arr[1]);
                            p.Direction = float.Parse(arr[2]);
                            p.Diameter = float.Parse(arr[3]);
                            p.Type = (PipeType)Enum.Parse(typeof(PipeType), arr[4]);
                        }
                    }

                    while ((line = reader.ReadLine()) != null)
                    {
                        arr = line.Split(',');
                        Connection c = new Connection();
                        c.upperStructure = Program.CurrentJob.Structures.Find(x => x.Shot == arr[0]);
                        c.lowerStructure = Program.CurrentJob.Structures.Find(x => x.Shot == arr[1]);
                        c.upperEnd = c.upperStructure.Pipes.Find(x => x.ID == arr[2]);
                        c.lowerEnd = c.lowerStructure.Pipes.Find(x => x.ID == arr[3]);

                        Program.Connections.Add(c);
                    }

                    this.Hide();
                    (new JobStructures()).Show();
                }
            }
        }

        private void btn_UploadShotFile_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = Application.StartupPath;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {

                using (StreamReader reader = new StreamReader(openFileDialog2.FileName))
                {
                    string line;
                    Program.CurrentJob = new Job(Path.GetFileNameWithoutExtension(openFileDialog2.FileName));

                    while ((line=reader.ReadLine()) != null)
                    {
                        string[] arr = line.Split(',');
                        string[] typeLabel = arr[4].Split('-');

                        //check if shot is structure, if so, add structure and info
                        //arr = shot, northing, easting, elevation,type-label
                        if (Enum.IsDefined(typeof(StructureType), typeLabel[0]))
                        {
                            Structure s = new Structure();
                            Program.CurrentJob.Structures.Add(s);
                            s.Shot = arr[0];
                            s.Northing = float.Parse(arr[1]);
                            s.Easting = float.Parse(arr[2]);
                            s.Elevation = float.Parse(arr[3]);
                            s.Type = (StructureType)Enum.Parse(typeof(StructureType), typeLabel[0]);
                        }
                    }
                    this.Hide();
                    (new JobStructures()).Show();
                }
            }
        }
    }
}
