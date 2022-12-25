using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Snow_GDI
{
    public partial class Form1 : Form
    {
        private Bitmap BackBuffer;

        public Form1()
        {
            InitializeComponent();

            BackBuffer = new Bitmap(400, 400);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}