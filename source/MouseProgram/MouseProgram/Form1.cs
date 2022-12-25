using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MouseProgram
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Text = "마우스 누름";
            label8.Text = e.Button.ToString();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            label2.Text = "마우스 떼어냄";
            label5.Text = e.X.ToString();
            label6.Text = e.Y.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
         
        }
    }
}