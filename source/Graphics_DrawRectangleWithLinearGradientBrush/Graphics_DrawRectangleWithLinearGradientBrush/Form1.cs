using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Graphics_DrawRectangleWithLinearGradientBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            Graphics g = frm.CreateGraphics();
            Brush newBrush = new LinearGradientBrush(new Point(0, 0), new Point(100, 100), Color.White, Color.Blue);

            g.FillRectangle(newBrush, new Rectangle(100, 100, 200, 200));

            g.Dispose();
        }
    }
}