using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics_DoubleBuffering
{
    public partial class Form1 : Form
    {
        private Timer tm = new Timer();
        
        public Form1()
        {
            InitializeComponent();
        }

        void DrawManyObject(Graphics g)
        {
            // 백 버퍼에 그림을 그린다. 
            // 모든 그림을 그린 후에 비디오 메모리를 교체한다.
            Random rnd = new Random();
            GDIBuffer.Instance().GetGraphics.Clear(Color.Red);
            Pen newPen = new Pen(Brushes.Black);
            for (int i = 0; i < 10000; i++)
            {
                int x = rnd.Next(0, ClientRectangle.Width);
                int y = rnd.Next(0, ClientRectangle.Height);
                int w = 30;
                int h = 30;
                GDIBuffer.Instance().GetGraphics.DrawRectangle(newPen, x, y, w, h);                
            }
            newPen.Dispose();

            g.DrawImage(GDIBuffer.Instance().GetImage, new Point(0, 0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tm.Enabled = true;
            tm.Interval = 30;
            tm.Tick += new EventHandler(tm_Tick);

            GDIBuffer.Instance(ClientRectangle.Width, ClientRectangle.Height);
        }

        void tm_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            DrawManyObject(g);
            g.Dispose();
        }
    }
}