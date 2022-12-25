using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Graphics_DrawRectangleWithHatchBrush
{
    public partial class HatchStyleViewer : Form
    {
        public HatchStyleViewer()
        {
            InitializeComponent();
        }

        private void HatchStyleViewer_Load(object sender, EventArgs e)
        {

        }

        private void HatchStyleViewer_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;
            int y = 0;

            Graphics g = e.Graphics;
            
            foreach (HatchStyle hs in Enum.GetValues(typeof(HatchStyle)))
            {
                Brush br = new HatchBrush( hs, Color.White, Color.Black );

                g.FillRectangle(br, x * 180, y * 30, 20, 20);
                g.DrawString(hs.ToString(), Font, Brushes.Black, x * 180 + 20, y * 30);

                x++;
                if (x % 5 == 0)
                {
                    y++;
                    x = 0;
                }
                br.Dispose();
            }
        }
    }
}