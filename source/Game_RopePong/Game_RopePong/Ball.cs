using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Resources;
using System.IO;

namespace Game_RopePong
{
    class Ball
    {
        public MassBasedPoint Point;
        private Vector2D orign;
        private GameWorld pWorld = null;
        private int State;
        private Bitmap[] ballimg = new Bitmap[8];
        private static int idx;

        public Ball(int width, int height, GameWorld world_)
        {
            State = 0;

            Point = new MassBasedPoint();
            Point.Mass = 20;
            Point.Radius = 8;
            Point.Elasticity = 1; // 탄성 계수를 설정

            Point.Position = new Vector2D(width / 2, 0);
            Point.Velocity = new Vector2D();
            Point.ConstForce = new Vector2D(0, 0.9 * 2);            
            Point.ImpulseForce = new Vector2D();

            orign.x = -11;
            orign.y = -11;

            pWorld = world_;

            ballimg[0] = new Bitmap(typeof(Ball), "ball1.bmp");
            ballimg[1] = new Bitmap(typeof(Ball), "ball2.bmp");
            ballimg[2] = new Bitmap(typeof(Ball), "ball3.bmp");
            ballimg[3] = new Bitmap(typeof(Ball), "ball4.bmp");
            ballimg[4] = new Bitmap(typeof(Ball), "ball5.bmp");
            ballimg[5] = new Bitmap(typeof(Ball), "ball6.bmp");
            ballimg[6] = new Bitmap(typeof(Ball), "ball7.bmp");
            ballimg[7] = new Bitmap(typeof(Ball), "ball8.bmp");

            for (int i = 0; i < ballimg.Length; i++)
            {
                ballimg[i].MakeTransparent(Color.Magenta);
            }
        }

        public void Collision()
        {
            if ( State == 0 ) {
                State = 1;
                
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.ball);
                simpleSound.Play();
                simpleSound.Dispose();
            }
        }            

        public void Update()
        {
            Point.Update(2);            
            pWorld.UpdateBall(this);
            
            Vector2D pos = Point.Position;
            Vector2D vel = Point.Velocity;

            if (pos.x < 0)
            {
                pos.x = 0;
                vel.x *= -1;
                Point.Position = pos;
                Point.Velocity = vel;
            }
            if (pos.x > pWorld.Width)
            {
                pos.x = pWorld.Width - 1;
                vel.x *= -1;
                Point.Position = pos;
                Point.Velocity = vel;
            }

            Vector2D dampening;
            dampening = Point.Velocity * -0.08;
            Point.Velocity = Point.Velocity + dampening;

            if (Point.Position.y < pWorld.ViewPortY)
            {
                pWorld.ViewPortY -= pWorld.ViewPortY - (int)Point.Position.y;                
            }
        }

        public void Render(Graphics g)
        {
            g.DrawImage(ballimg[idx], (int)(Point.Position.x + orign.x), (int)(Point.Position.y + orign.y) - pWorld.ViewPortY);

            if (State == 1)
            {
                idx++;
                if (idx > 7)
                {
                    idx = 0;
                    State = 0;
                }
            }
        }
    }
}
