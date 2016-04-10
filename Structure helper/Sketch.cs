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
    public partial class Sketch : Form
    {
        public Sketch()
        {
            InitializeComponent();
        }

        float MapScale
        {
            get { return (sketchArea.Width-20)/(MaxEasting - MinEasting); }
        }

        float MaxEasting
        {
            //find smallest easting for all structure coords
            get { return Program.CurrentJob.Structures.Max(x => x.Easting); }
        }

        float MinEasting
        {
            //find largest easting for all structure coords
            get { return Program.CurrentJob.Structures.Min(x => x.Easting); }
        }

        float MaxNorthing
        { get { return Program.CurrentJob.Structures.Max(x => x.Northing); } }


        public void sketchArea_PaintStructuresTop(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            SolidBrush brush = new SolidBrush(Color.Black);
            foreach (Structure s in Program.CurrentJob.Structures)
            {
                int x = Convert.ToInt32((s.Easting - MinEasting) * MapScale + 10);
                int y = Convert.ToInt32((MaxNorthing - s.Northing) * MapScale + 10);
                Rectangle rect = new Rectangle(x, y, 10, 10);
                s.Rect = rect;
                e.Graphics.FillEllipse(brush, rect);
            }
        }

        public void sketchArea_PaintStructuresSide(object sender, PaintEventArgs e)
        {

        }

        public void sketchArea_PaintConnections(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 4);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;

            Point start = new Point();
            Point end = new Point();
            float maxNorthing = Program.CurrentJob.Structures.Max(x => x.Northing);

            foreach (Connection c in Program.Connections)
            {
                start.X = Convert.ToInt32(MapScale * (c.upperStructure.Easting - MinEasting)) + 10;
                start.Y = Convert.ToInt32(MapScale * (maxNorthing - c.upperStructure.Northing)) + 10;
                end.X = Convert.ToInt32(MapScale * (c.lowerStructure.Easting - MinEasting)) + 10;
                end.Y = Convert.ToInt32(MapScale * (maxNorthing - c.lowerStructure.Northing)) + 10;
                e.Graphics.DrawLine(pen, start, end);
            }
            
            SolidBrush brush = new SolidBrush(Color.Black);
            foreach (Structure s in Program.CurrentJob.Structures)
            {
                int x = Convert.ToInt32((s.Easting - MinEasting) * MapScale + 10);
                int y = Convert.ToInt32((MaxNorthing - s.Northing) * MapScale + 10);
                Rectangle rect = new Rectangle(x-5, y-5, 10, 10);
                s.Rect = rect;
                e.Graphics.FillEllipse(brush, rect);
            }
        }        

        private void sketchArea_Resize(object sender, EventArgs e)
        {
            sketchArea.Refresh();
        }

        private void sketchArea_MouseClick(object sender, MouseEventArgs e)
        {
            foreach(Structure s in Program.CurrentJob.Structures)
                if (s.Rect.Contains(sketchArea.PointToClient(MousePosition)))
                {
                    EnterStructInfo structInfo = new EnterStructInfo(s);
                    structInfo.Show();
                }
        }

        public PictureBox SketchArea { get { return sketchArea; } }

        private void btn_ShowConnections_Click(object sender, EventArgs e)
        {
            sketchArea.Paint += new PaintEventHandler(sketchArea_PaintConnections);
            sketchArea.Refresh();
        }
    }
}
