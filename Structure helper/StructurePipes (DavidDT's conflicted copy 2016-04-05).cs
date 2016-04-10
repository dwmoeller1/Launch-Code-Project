using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Structure_helper
{
    public partial class StructurePipes : Form
    {
        public new Form Parent { get; set; }
        private Structure structure;
        
        public StructurePipes(Structure structure)
        {
            InitializeComponent();
            lstbx_Pipes.DataSource = structure.Pipes;
            lstbx_Pipes.DisplayMember = "ID";
            this.structure = structure;
            DrawStructure();
        }

        private void btn_AddPipe_Click(object sender, EventArgs e)
        {
            EnterPipeInfo enterPipeInfo = new EnterPipeInfo(structure);
            this.Hide();
            enterPipeInfo.Show();
            enterPipeInfo.Parent = this;
        }

        private void btn_EditPipe_Click(object sender, EventArgs e)
        {            
            PipeEnd p = (PipeEnd)lstbx_Pipes.SelectedItem;
            EnterPipeInfo enterPipeInfo = new EnterPipeInfo(structure, false,p);
            this.Hide();
            enterPipeInfo.Show();
            enterPipeInfo.Parent = this;            
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StructurePipes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Show();
        }

        public void DrawStructure()
        {
            Graphics graphics = sketchArea.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            
            Point center = new Point(sketchArea.Width / 2, sketchArea.Height / 2);
            int height = sketchArea.Height / 3, width = height;
            int x = center.X - height / 2;
            int y = center.Y - height / 2;

            Rectangle rect = new Rectangle(x,y,width,height);
            Pen pen;

            foreach (PipeEnd p in structure.Pipes)
            {
                if (p.Flow == Flow.In)
                    pen = new Pen(Color.Black, 4);
                else
                    pen = new Pen(Color.Red, 4);

                pen.EndCap = LineCap.ArrowAnchor;


                double angle = (90-p.Direction)*Math.PI/180;
                Point endPoint = new Point(Convert.ToInt32(center.X + Math.Cos(angle) * height), center.Y - Convert.ToInt32(Math.Sin(angle) * height));
                graphics.DrawLine(pen, center,endPoint);
            }

            graphics.FillEllipse(brush, rect);
        }



        
    }
}
