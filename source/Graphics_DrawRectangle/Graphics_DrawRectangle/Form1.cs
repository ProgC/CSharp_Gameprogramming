using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics_DrawRectangle
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
            Pen newPen = new Pen(Color.Black);
            
            g.DrawRectangle(newPen, new Rectangle(100, 100, 50, 80));

            newPen.Dispose();
            g.Dispose();
        }
    }
}