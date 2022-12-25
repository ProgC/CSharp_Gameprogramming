using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Game_RopePong
{
    public partial class Form1 : Form
    {
        private Ball ball = null;
        private GameWorld World = null;
        private Timer tm;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            World = new GameWorld(this.Width, this.Height);
            ball = new Ball(this.Width, this.Height, World);

            tm = new Timer();
            tm.Enabled = true;
            tm.Interval = 30;
            tm.Tick += new EventHandler(tm_Tick);
        }

        void tm_Tick(object sender, EventArgs e)
        {
            ball.Update();
            World.Update();            
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            World.Render(g);
            ball.Render(g);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                World.BeginRope(e.X, e.Y);
            }            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                World.EndRope(e.X, e.Y);
            }
        }
    }
}