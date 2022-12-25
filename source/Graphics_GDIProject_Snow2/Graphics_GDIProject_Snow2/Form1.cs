using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics_GDIProject_Snow2
{
    public partial class Form1 : Form
    {
        private Timer tm = null;
        SnowWorld World = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tm = new Timer();
            tm.Enabled = true;
            tm.Interval = 30;
            tm.Tick += new EventHandler(tm_Tick);

            World = new SnowWorld(ClientRectangle.Width, ClientRectangle.Height);

            // 백버퍼를 만든다.
            GDIBuffer.Instance(ClientRectangle.Width, ClientRectangle.Height);
        }

        void tm_Tick(object sender, EventArgs e)
        {
            FrameUpdate();
            FrameRender();
        }

        // 자료의 업데이트를 담당한다.
        private void FrameUpdate()
        {
            World.Update();
        }

        // 모든 객체를 그린다.
        private void FrameRender()
        {
            World.Render();

            // 백버퍼의 화면을 전면 비디오 메모리로 옮긴다.
            Graphics g = CreateGraphics();
            g.DrawImage(GDIBuffer.Instance().GetImage, new Point(0, 0));
            g.Dispose();
        }
    }
}