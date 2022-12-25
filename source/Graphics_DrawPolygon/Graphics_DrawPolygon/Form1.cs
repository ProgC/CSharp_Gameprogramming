using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics_DrawPolygon
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
            Form1 frm = (Form1)sender;
            Graphics g = frm.CreateGraphics();

            Pen newPen = new Pen(Brushes.Red);
            Point[] pt = new Point[] {
                new Point(100,100),
                new Point(150,100),
                new Point(150,130),
                new Point(180,130),
                new Point(180,160),
                new Point(150,160),
                new Point(150,190),
                new Point(100,190)
            };
            
            g.FillPolygon(Brushes.Peru, pt);
            g.DrawPolygon(newPen, pt);

            newPen.Dispose();
            g.Dispose();
        }
    }
}