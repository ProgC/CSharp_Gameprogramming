using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Graphics_GDIProject_Snow
{
    class Snow
    {
        private double x = 0;
        private double y = 0;

        private double vx = 0;
        private double vy = 0;

        private SnowWorld World = null;

        public Snow(int x, int y, SnowWorld world_ )
        {
            this.x = (double)x;
            this.y = (double)y;
            this.World = world_;
        }

        public void Update()
        {
            y = y + 0.1;
        }

        public void Render()
        {
            Pen newPen = new Pen(Brushes.White);
            GDIBuffer.Instance().GetGraphics.DrawEllipse(newPen, (int)x, (int)y, 2, 2);
            newPen.Dispose();
        }
    }
}
