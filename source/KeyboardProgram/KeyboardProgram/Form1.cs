using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeyboardProgram
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys k = e.KeyCode;

            if (k == Keys.Left)
            {
                label1.Left -= 2;
            }
            if (k == Keys.Right)
            {
                label1.Left += 2;
            }
            if (k == Keys.Up)
            {
                label1.Top -= 2;
            }
            if (k == Keys.Down)
            {
                label1.Top += 2;
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                 
        }      
    }
}