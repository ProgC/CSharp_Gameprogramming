using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Graphics_DrawRectangleWithPathGradientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 frm = (Form1)sender;
            Graphics g = frm.CreateGraphics();

            Point[] pt = { new Point(0, 0), new Point(100, 100), new Point(100, 0) };

            PathGradientBrush newBrush = new PathGradientBrush(pt);
            newBrush.CenterColor = Color.Blue;
            newBrush.SurroundColors = new Color[] { Color.Red, Color.Blue, Color.Green };
            Pen newPen = new Pen(Color.Black);

            g.FillRectangle(newBrush, 0, 0, 100, 100);
            g.DrawRectangle(newPen, 0, 0, 100, 100);

            newPen.Dispose();
            newBrush.Dispose();
            g.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}