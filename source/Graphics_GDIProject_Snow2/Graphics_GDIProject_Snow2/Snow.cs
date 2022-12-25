using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Graphics_GDIProject_Snow2
{
    class Snow
    {
        private double x = 0;
        private double y = 0;

        private double vx = 0;
        private double vy = 0;

        private SnowWorld World = null;
        static Random rnd = new Random();

        public Snow(int x, int y, SnowWorld world_ )
        {
            this.x = (double)x;
            this.y = (double)y;
            

            this.vx = 0.5 - rnd.NextDouble();
            this.vy = rnd.NextDouble() + 1;
            
            this.World = world_;
        }

        private void ResetPosition()
        {            
            x = rnd.Next(World.Width);
            y = -rnd.Next(15);

            vx = 0.5 - rnd.NextDouble();
            vy = rnd.NextDouble() + 1;
        }

        public void Update()
        {
            x += vx;
            y += vy;

            if (x < 0) ResetPosition();
            if (x > World.Width) ResetPosition();
            if (y > World.Height) ResetPosition();            
        }

        public void Render()
        {
            Pen newPen = new Pen(Brushes.White);

            int Scale = (int)((Math.Abs(vy) / 2) * 3);

            GDIBuffer.Instance().GetGraphics.DrawEllipse(newPen, (int)x, (int)y, Scale, Scale);
            newPen.Dispose();
        }
    }
}
