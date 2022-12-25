using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Graphics_DrawCircleWithPathGradientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen newPen = new Pen(Brushes.Black);
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(100, 100, 100, 100);

            PathGradientBrush newBrush = new PathGradientBrush(p);
            newBrush.CenterPoint = new Point(130, 130);
            newBrush.CenterColor = Color.White;
            newBrush.SurroundColors = new Color[] { Color.Peru };
            
            g.FillEllipse(newBrush, 100, 100, 100, 100);
            g.DrawEllipse(newPen, 100, 100, 100, 100);

            newBrush.Dispose();
            p.Dispose();
            newPen.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}