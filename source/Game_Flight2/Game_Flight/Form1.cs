using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KModule;

namespace Game_Flight2
{
    public partial class Form1 : Form
    {
        private Timer tm;
        private FlightWorld world = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KController.Instance();

            world = new FlightWorld(ClientRectangle.Width, ClientRectangle.Height);
            
            tm = new Timer();
            tm.Enabled = true;
            tm.Interval = 30;
            tm.Tick += new EventHandler(tm_Tick);
        }

        void tm_Tick(object sender, EventArgs e)
        {
            // Game Framework            
            KController.Instance().Update();
            FrameUpdate();
            FrameRender();
        }

        private void FrameUpdate()
        {
            if (world != null)
            {
                world.FrameUpdate();
            }
        }

        private void FrameRender()
        {            
            if (world != null)
            {                
                world.FrameRender();
            }

            // 백버퍼의 화면을 전면 비디오 메모리로 옮긴다.
            Graphics g = CreateGraphics();
            g.DrawImage(GDIBuffer.Instance().GetImage, new Point(0, 0));
            g.Dispose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           // label1.Text = e.KeyCode.ToString();
            KController.Instance().OnKeyDown(e.KeyValue);
                        
            //Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           // label2.Text = e.KeyCode.ToString();
            KController.Instance().OnKeyUp(e.KeyValue);
           // Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*int x = 0;
            int y = 0;
            for (int i = 0; i < KController.Instance().CountOfKey(); i++)
            {
                e.Graphics.DrawString(KController.Instance().GetKeyState(i).ToString(), Font, Brushes.Black,new PointF(x * 40, y * 20));
                x++;

                if ((x % 20) == 0)
                {
                    x = 0;
                    y++;
                }
            }*/
        }
    }
}