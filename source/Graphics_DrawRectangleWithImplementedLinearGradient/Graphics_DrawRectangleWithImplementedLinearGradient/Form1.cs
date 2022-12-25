using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics_DrawRectangleWithImplementedLinearGradient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LinearGradientFill(Graphics gr,Color A, Color B, int height)
        {
            float r;
            float g;
            float b;
            float dr = (float)((B.R - A.R) / (float)height);
            float dg = (float)((B.G - A.G) / (float)height);
            float db = (float)((B.B - A.B) / (float)height);

            r = A.R;
            g = A.G;
            b = A.B;

            Pen newPen = new Pen(Color.FromArgb((int)r, (int)g, (int)b));
            for (int y = 0; y < height; y++)
            {
                gr.DrawLine(newPen, 0, y, ClientRectangle.Width, y);
                r += dr;
                g += dg;
                b += db;

                newPen.Color = Color.FromArgb((int)r, (int)g, (int)b);
            }
            newPen.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            LinearGradientFill(g, Color.White, Color.Blue, ClientRectangle.Height);            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}