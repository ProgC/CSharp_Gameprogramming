using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics_Pixel_with_Drawing
{
    public partial class Form1 : Form
    {
        private Bitmap bmOnePixel = new Bitmap(1, 1);
        private bool bClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetPixel(int x, int y, Color color)
        {
            Graphics g = this.CreateGraphics();
            bmOnePixel.SetPixel(0, 0, color);
            g.DrawImage(bmOnePixel, new Point(x, y));
            g.Dispose();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {            
            SetPixel(e.X, e.Y, Color.Black);
            bClicked = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bClicked)
            {
                SetPixel(e.X, e.Y, Color.Black);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bClicked = false;
        }
    }
}