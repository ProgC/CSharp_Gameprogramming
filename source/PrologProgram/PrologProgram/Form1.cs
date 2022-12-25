using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrologProgram
{
    public partial class Form1 : Form
    {
        private Timer tm;
        public Form1()
        {
            InitializeComponent();

            tm = new Timer();
            tm.Enabled = true;
            tm.Interval = 30;
            tm.Tick += new EventHandler(OnTimer);

            
        }
                
        public void OnTimer(object sender, EventArgs e)
        {
            textBox1.Top--;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            //box.                                    
        }
    }
}