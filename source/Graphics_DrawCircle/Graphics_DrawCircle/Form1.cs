using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics_DrawCircle
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

        private void DrawCircle(Graphics g, Pen pen, int x, int y, int r)
        {
            g.DrawEllipse(pen, x - r, y - r, r*2, r*2);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 frm = (Form1)sender;
            Graphics g = frm.CreateGraphics();

            Pen newPen = new Pen(Brushes.Black);
            g.DrawEllipse(newPen, 100, 100, 100, 100);
            DrawCircle(g, newPen, 100, 100, 50);
            
            newPen.Dispose();
            g.Dispose();
        }
    }
}