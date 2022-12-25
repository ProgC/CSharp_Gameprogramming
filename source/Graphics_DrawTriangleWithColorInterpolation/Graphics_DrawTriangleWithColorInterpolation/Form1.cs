using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics_DrawTriangleWithColorInterpolation
{
    public partial class Form1 : Form
    {
        // 일반 삼각형은 숙제!
        /*private Triangle2D tri = new Triangle2D(100,100, -100, 200, 300, 300,
                                                255,0,0,
                                                0,255,0,
                                                0,0,255);*/

        private Triangle2D tri = new Triangle2D(100,100, 50, 250, 200, 250,
                                                255,0,0,
                                                0,255,0,
                                                0,0,255);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            tri.Draw(g);            

            Pen newPen = new Pen( Brushes.Red );
            g.DrawRectangle(newPen, 100, 100, 2, 2);
            g.DrawRectangle(newPen, 50, 250, 2, 2);
            g.DrawRectangle(newPen, 200, 250, 2, 2);
            newPen.Dispose();
        }
    }
}