using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Graphics_DrawRectangleWithHatchBrush
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
            Brush newBrush = new HatchBrush(HatchStyle.HorizontalBrick, Color.White, Color.Blue);

            g.FillRectangle(newBrush, new Rectangle(100, 100, 200, 200));

            g.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HatchStyleViewer frm = new HatchStyleViewer();
            frm.Show();

        }
    }
}