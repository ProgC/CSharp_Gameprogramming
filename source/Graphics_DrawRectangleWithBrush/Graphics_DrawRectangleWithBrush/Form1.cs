using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection; // 반영을 위한 using

namespace Graphics_DrawRectangleWithBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //색상을 보려면 주석 해제
            //BrushesTable table = new BrushesTable();
            //table.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            Graphics g = frm.CreateGraphics();
            Pen newPen = new Pen(Color.Black);
            Brush newBrush = Brushes.Red;

            g.FillRectangle(Brushes.Red, new Rectangle(100, 100, 200, 200));
                        
            newPen.Dispose();
            g.Dispose();
        }
    }
}