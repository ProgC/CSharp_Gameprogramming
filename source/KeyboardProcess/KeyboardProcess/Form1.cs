using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeyboardProcess
{
    public partial class Form1 : Form
    {
        Timer tm = new Timer();

        public Form1()
        {
            InitializeComponent();

            tm.Enabled = true;
            tm.Interval = 30;
            
        }

        void tm_Tick(object sender, EventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            
            this.Text = "...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick);
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            

            

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                chkArrowUp.Checked = true;

            if (e.KeyCode == Keys.Down)
                chkArrowDown.Checked = true;
        }
    }
}