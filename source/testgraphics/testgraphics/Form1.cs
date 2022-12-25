using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace testgraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            const int xOffset = 10; // 10밀리
            const int yOffset = 10;
                        
            Graphics g = e.Graphics;

            //g.PageUnit = GraphicsUnit.Millimeter;
            //g.PageScale = 1f;

            
            g.DrawPolygon(pen, new PointF[] {
                MMConv( g, new PointF(xOffset, yOffset)),
                MMConv( g, new PointF(xOffset+100, yOffset)),
                MMConv( g, new PointF(xOffset+100, yOffset+10)),
                MMConv( g, new PointF(xOffset, yOffset+10))
            });

            StringFormat strfmt = new StringFormat();

            strfmt.Alignment = StringAlignment.Center;

            for (int i = 1; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    g.DrawLine(pen, 
                        MMConv( g, new PointF( xOffset + i, yOffset )),
                        MMConv( g, new PointF( xOffset + i, yOffset + 5)));

                    g.DrawString( (i/10).ToString(), Font, brush,
                        MMConv( g, new Point(xOffset + i, yOffset + 6)),
                        strfmt);
                }
                else if ((i % 5) == 0)
                {
                    g.DrawLine(pen,
                        MMConv(g, new PointF(xOffset + i, yOffset)),
                        MMConv(g, new PointF(xOffset + i, yOffset + 3)));

                }
                else
                {
                    g.DrawLine(pen,
                        MMConv(g, new PointF(xOffset + i, yOffset)),
                        MMConv(g, new PointF(xOffset + i, yOffset + 2.5f)));

                }
            }

            
        }

        PointF MMConv(Graphics grfx, PointF pointf)
        {
            pointf.X *= grfx.DpiX / 25.4f;
            pointf.Y *= grfx.DpiY / 25.4f;
            return pointf;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}