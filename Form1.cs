using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        private float x1, x2, x3, y1, y2, y3, x4, y4, r1, r2, r3;
        private double a1, a2, a3;
        private SolidBrush b2 = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            PointF p1 = new PointF(x1, y1);
            PointF p2 = new PointF(x2, y2);
            PointF p3 = new PointF(x3, y3);
            PointF p4 = new PointF(x4, y4);
            PointF[] points = {p1, p2, p3, p4};
            g.FillClosedCurve(b2, points);

            label1.Text = x2.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a1 = 0;
            a2 = 0.4;
            a3 = 0.9;
            r1 = 200;
            r2 = 70;
            r3 = 200;
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            x2 = x1 + (int)(r1 * Math.Cos(a1));
            y2 = y1 - (int)(r1 * Math.Sin(a1));
            x3 = x1 + (int)(r2 * Math.Cos(a2));
            y3 = y1 - (int)(r2 * Math.Sin(a2));
            x4 = x1 + (int)(r3 * Math.Cos(a3));
            y4 = y1 - (int)(r3 * Math.Sin(a3));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a1 -= 0.1;
            a2 -= 0.1;
            a3 -= 0.1;
            x2 = x1 + (int)(r1 * Math.Cos(a1));
            y2 = y1 - (int)(r1 * Math.Sin(a1));
            x3 = x1 + (int)(r2 * Math.Cos(a2));
            y3 = y1 - (int)(r2 * Math.Sin(a2));
            x4 = x1 + (int)(r3 * Math.Cos(a3));
            y4 = y1 - (int)(r3 * Math.Sin(a3));
            Invalidate();
        }
    }
}
