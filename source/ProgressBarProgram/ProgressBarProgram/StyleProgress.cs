using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace ProgressBarProgram
{
    class StyleProgress : ProgressBar
    {
        private readonly int width;
        private readonly int height;
        private Bitmap img_background;
        private Bitmap img_value;
        private Rectangle rectShape;
        private Rectangle rectValueShape;
                        
        public StyleProgress()
        {
            width = 108;
            height = 9;
            img_background = new Bitmap(GetType(), "background.bmp" );            
            img_value = new Bitmap(GetType(), "each.bmp");
            
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            rectShape = new Rectangle(0, 0, width, height);
            rectValueShape = new Rectangle(0, 0, 0, height);
        }
        
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Width = width;
            Height = height;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.DrawImage(img_background, rectShape);
            
            rectValueShape.Width = (int)( (float)(Value / (float)(Maximum - Minimum)) * width);

            g.DrawImage(img_value, rectValueShape, rectValueShape, GraphicsUnit.Pixel);
        }
    }
}
