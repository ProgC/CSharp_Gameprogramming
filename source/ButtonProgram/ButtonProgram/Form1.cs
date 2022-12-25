using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ButtonProgram
{
    public partial class Form1 : Form
    {
        private int Str = 0;
        private int Wis = 0;
        private int Dex = 0;

        public Form1()
        {
            InitializeComponent();

            lblStr.Text = Str.ToString();
            lblWis.Text = Wis.ToString();
            lblDex.Text = Dex.ToString();
        }
        
        private void myButton1_Click(object sender, EventArgs e)
        {
            Str++;
            lblStr.Text = Str.ToString();
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            Wis++;
            lblWis.Text = Wis.ToString();
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            Dex++;
            lblDex.Text = Dex.ToString();
        }            
    }
}