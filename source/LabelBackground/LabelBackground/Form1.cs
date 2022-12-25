using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabelBackground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;
            Graphics g = e.Graphics;

            g.DrawRectangle(new Pen(lbl.ForeColor), e.ClipRectangle);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}