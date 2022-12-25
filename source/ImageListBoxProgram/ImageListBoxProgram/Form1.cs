using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageListBoxProgram
{
    public partial class Form1 : Form
    {
        private Bitmap bmString;
        private Bitmap bmNumber;

        public Form1()
        {
            InitializeComponent();

            // 비트맵 생성
            bmString = new Bitmap(GetType(), "s.bmp");
            bmNumber = new Bitmap(GetType(), "n.bmp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strData = "문자열 데이터";
            int nData = 30;
            listBox1.Items.Add(strData);
            listBox1.Items.Add(nData);            
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox lstBox = (ListBox)sender;
            Graphics g = e.Graphics;
            e.DrawBackground();
            Rectangle rect = new Rectangle(e.Bounds.Left + 13, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);
            
            if (lstBox.Items[e.Index] is String)
            {
                g.DrawImage(bmString, e.Bounds.Left, e.Bounds.Top);
            }
            if (lstBox.Items[e.Index] is int)
            {
                g.DrawImage(bmNumber, e.Bounds.Left, e.Bounds.Top);
            }

            g.DrawString( lstBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), rect.Left, rect.Top );            
            e.DrawFocusRectangle(); 
           
        }       
    }
}