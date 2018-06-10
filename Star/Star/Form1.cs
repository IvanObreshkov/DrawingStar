using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingStar
{
    public partial class Form1 : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            int cx = ClientSize.Width;
            int cy = ClientSize.Height;
            Point[] point = new Point[5];
            for (int i = 0; i < 5; i++)
            {
                double angle = (i * 0.8 - 0.5) * Math.PI;
                point[i] = new Point((int)(cx * (0.25 + 0.24 * Math.Cos(angle))),
                (int)(cy * (0.5 + 0.48 * Math.Sin(angle))));
            }
            g.DrawPolygon(p, point);
            Brush b = new SolidBrush(Color.Aqua);
            g.FillPolygon(b, point);
            g.DrawPolygon(p, point);
            g.FillPolygon(b, point, System.Drawing.Drawing2D.FillMode.Winding);
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
