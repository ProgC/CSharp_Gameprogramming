using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testpenprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.Black);

            float y = 0;

            Graphics g = e.Graphics;

            

            g.PageUnit = GraphicsUnit.Point;
            g.PageScale = 1;

            g.RotateTransform(-45);

            for (float f = 0; f < 3.2; f += 0.2f)
            {
                Pen pen = new Pen(Color.Black, f);
                string str = String.Format("{0:F1} point wide pen : ", f);
                SizeF sizef = g.MeasureString(str, Font);

                g.DrawString(str, Font, brush, 0, y);
                g.DrawLine(pen, sizef.Width, y + sizef.Height / 2, sizef.Width + 144, y + sizef.Height / 2);

                y += sizef.Height;
            }
        }
    }
}