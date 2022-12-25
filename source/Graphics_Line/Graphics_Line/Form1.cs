using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Graphics_Line
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form frm = (Form1)sender;
            Graphics g = frm.CreateGraphics();

            Pen newPenDefault = new Pen(Color.Black);
            Pen newPenAtt = new Pen(Color.Red);

            newPenAtt.Width = 10;
            
            int x = 100;
            int y = 20;
                      
            foreach (LineCap att in Enum.GetValues(typeof(LineCap)))
            {
                g.DrawString(att.ToString(), Font, new SolidBrush(Color.Black), 0, y);
                newPenAtt.EndCap = att;

                if ( (int)(att & LineCap.AnchorMask) > 0 )
                {
                    newPenAtt.Color = Color.Green;
                }
                else
                {
                    newPenAtt.Color = Color.Red;
                }

                g.DrawLine(newPenAtt, new Point(x, y), new Point(x+100, y));
                g.DrawLine(newPenDefault, new Point(x, y), new Point(x+100, y));

                y += (int)Font.GetHeight(g)*2;
            }

            newPenAtt.Dispose();
            newPenDefault.Dispose();            
            g.Dispose();
        }
    }
}