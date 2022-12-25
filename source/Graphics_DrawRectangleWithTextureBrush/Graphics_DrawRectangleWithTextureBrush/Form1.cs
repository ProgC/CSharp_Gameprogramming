using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Graphics_DrawRectangleWithTextureBrush
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            Graphics g = frm.CreateGraphics();
            Image img = new Bitmap(typeof(Form1), "MyImage.bmp" );
            TextureBrush newBrush = new TextureBrush(img);
            newBrush.WrapMode = System.Drawing.Drawing2D.WrapMode.TileFlipX;
            Matrix tm = new Matrix();
            tm.Rotate(30);
            newBrush.Transform = tm;

            g.FillRectangle(newBrush, new Rectangle(10, 10, 300, 300));

            img.Dispose();
            newBrush.Dispose();
            g.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}