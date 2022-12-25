using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics_LineDrawingAnimation
{
    public partial class Form1 : Form
    {
        private Bitmap bmOnePixel = new Bitmap(1, 1);
        private bool bClicked = false;
        private ArrayList ActionList = new ArrayList();
        private Action act;
        private Random rnd = new Random();
        private Timer tm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tm = new Timer();
            tm.Enabled = true;
            tm.Interval = 100;
            tm.Tick += new EventHandler(tm_Tick);
        }

        void tm_Tick(object sender, EventArgs e)
        {
            Invalidate();            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bClicked = true;

            if (e.Button == MouseButtons.Left)
            {
                act = new Action();
                act.nType = Action.ActionType.Point;
            }
            else if (e.Button == MouseButtons.Right)
            {
                act = new Action();
                act.nType = Action.ActionType.Line;
                act.nSX = e.X;
                act.nSY = e.Y;
            }

            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 왼쪽 마우스 버튼으로 그리면 점을 찍는다.
            // 오른쪽 마우스 버튼으로 그리면 라인을 그린다.
            if (e.Button == MouseButtons.Left)
            {
                act.nSX = e.X;
                act.nSY = e.Y;
                ActionList.Add(act);
            }
            else if ( e.Button == MouseButtons.Right )
            {
                act.nEX = e.X;
                act.nEY = e.Y;
            }

            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bClicked = false;

            if (act.nType == Action.ActionType.Line)
            {
                ActionList.Add(act);
            }

            Invalidate();
        }
                
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen newPen = new Pen(Color.Black);
            
            for (int i = 0; i < ActionList.Count; i++)
            {
                int dsx = rnd.Next(-3, 3);
                int dsy = rnd.Next(-3, 3);
                int dex = rnd.Next(-3, 3);
                int dey = rnd.Next(-3, 3);

                Action action = (Action)ActionList[i];
                if (action.nType == Action.ActionType.Point)
                {
                    bmOnePixel.SetPixel(0, 0, Color.Black);
                    g.DrawImage(bmOnePixel, action.nSX + dsx,
                                            action.nSY + dsy);
                }
                else if (action.nType == Action.ActionType.Line)
                {
                    g.DrawLine(newPen, action.nSX + dsx, 
                                       action.nSY + dsy, 
                                       action.nEX + dex,
                                       action.nEY + dey);

                                        
                }                
            }
            newPen.Dispose();
        }
    }

    public struct Action
    {
        public enum ActionType
        {
            Point,
            Line
        }

        public ActionType nType;

        public int nSX;
        public int nSY;
        public int nEX;
        public int nEY;
    }
}