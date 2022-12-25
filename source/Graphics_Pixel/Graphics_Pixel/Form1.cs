using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics_Pixel
{
    public partial class Form1 : Form
    {
        private Bitmap bmOnePixel = new Bitmap(1, 1);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form frm = (Form1)sender;
            Graphics g = frm.CreateGraphics();
                        
            bmOnePixel.SetPixel(0, 0, Color.Black);
            g.DrawImage(bmOnePixel, new Point(e.X, e.Y));
            g.Dispose();
        }
    }
}