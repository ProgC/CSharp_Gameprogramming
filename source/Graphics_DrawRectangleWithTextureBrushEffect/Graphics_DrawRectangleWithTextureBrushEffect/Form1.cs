using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Graphics_DrawRectangleWithTextureBrushEffect
{
    public partial class Form1 : Form
    {
        private Timer tm = new Timer();
        private Image Img = new Bitmap( typeof(Form1), "MyImage.bmp" );
        private double Zoom = 1;
        private int ox = 133;
        private int oy = 124;
        private bool bClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            TextureBrush newBrush = new TextureBrush(Img);

            if ( bClicked )
            {
                Matrix TransMat = new Matrix();
                Matrix S = new Matrix();                
                Matrix Ts = new Matrix();
                Matrix Te = new Matrix();
                
                newBrush.WrapMode = WrapMode.Clamp;

                S.Scale((float)Zoom, (float)Zoom);
                Ts.Translate(-ox, -oy);
                Te.Translate(ox, oy);

                TransMat.Multiply(Te);
                TransMat.Multiply(S);
                TransMat.Multiply(Ts);

                newBrush.Transform = TransMat;
            }

            g.FillRectangle(newBrush, 0, 0, 133, 124);

            newBrush.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tm.Enabled = true;
            tm.Interval = 30;
            tm.Tick += new EventHandler(tm_Tick);
        }

        void tm_Tick(object sender, EventArgs e)
        {
            if (bClicked)
            {
                Zoom += 0.01;
                if (Zoom > 50) Zoom = 1;
            }

            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bClicked = true;
            
            ox = e.X;
            oy = e.Y;
        }
    }
}