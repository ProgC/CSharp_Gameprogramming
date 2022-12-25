using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace LabelBackground
{
    class FocusedLabel : Label
    {
        private bool bIsinControl = false;
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            bIsinControl = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            bIsinControl = false;
            Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {            
            if (bIsinControl)
            {
                Graphics g = pevent.Graphics;
                Brush brush = new SolidBrush(Color.Brown);
                g.FillRectangle( brush, ClientRectangle );
            } 
            else
            {
                base.OnPaintBackground(pevent);
            }            
        }
    }
}
