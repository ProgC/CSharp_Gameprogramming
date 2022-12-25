using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Graphics_DrawRectangleWithBrush
{
    public partial class BrushesTable : Form
    {
        public BrushesTable()
        {
            InitializeComponent();
        }

        private void BrushesTable_Load(object sender, EventArgs e)
        {

        }

        private void BrushesTable_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen newPen = new Pen(Color.Black);
            
            PropertyInfo[] propertyinfo = typeof(Brushes).GetProperties();
            
            int x = 0;
            int y = 0;
            
            foreach (PropertyInfo info in propertyinfo)
            {
                Brush brush = (Brush)info.GetValue(null, null);

                g.FillRectangle(brush, new Rectangle(x*130, y*15, 10, 10));
                g.DrawRectangle(newPen, new Rectangle(x * 130, y * 15, 10, 10));
                g.DrawString(info.Name, Font, Brushes.Black, x * 130 + 10, y * 15);

                x++;
                if ((x % 5) == 0)
                {
                    y++;
                    x = 0;
                }
            }
             
            newPen.Dispose();
        }
    }
}