using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace Game_RopePong
{   
    class GameWorld
    {
        private int width;
        private int height;
        private bool bRopeExist = false;
        private Vector2D FromPoint = new Vector2D();
        private Vector2D ToPoint = new Vector2D();
        private Bitmap backImg;
        private int viewportY;
        
        private RopeSimulation RopeObj = new RopeSimulation();

        public GameWorld(int width_, int height_)
        {
            if (width_ == 0 || height_ == 0)
            {
                MessageBox.Show("월드를 생성할 수 없습니다.");
                return;
            }
            width = width_;
            height = height_;

            backImg = new Bitmap(typeof(GameWorld), "background.bmp");
            ViewPortY = 0;
        }

        #region GameWorldProperty
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public int ViewPortY
        {
            get
            {
                return viewportY;
            }
            set
            {
                viewportY = value;
            }
        }
        #endregion

        public void UpdateBall(Ball ball)
        {
           // 공이 아래로 떨어졌을 때 위로 올려준다.
           /*if (ball.Point.Position.y > ViewPortY+Height)
           {
               ball.Point.Position = new Vector2D(ball.Point.Position.x, ViewPortY+Height);
               ball.Point.Velocity = new Vector2D(ball.Point.Velocity.x, ball.Point.Velocity.y * (-1 * 5) );
           }*/

            Vector2D ballpos = ball.Point.Position;
            ballpos.y -= viewportY;
            Vector2D ballvel = ball.Point.Velocity;
            
            if (bRopeExist)
            {
                MassBasedPoint[] Points = RopeObj.GetPoints();

                int nCount = Points.GetLength(0);
                double dist = 0;
                for (int i = 0; i < nCount; i++)
                {
                    dist = Points[i].Position.Distance(ref ballpos);
                    if (dist < ball.Point.Radius+Points[i].Radius)
                    {
                        // 충돌이 되었다면 충돌 후의 속도를 구한다.
                        Vector2D N = Points[i].Position - ballpos;
                        N.Normalize();

                        double velocity1 = ballvel.Dot(N);
                        double velocity2 = Points[i].Velocity.Dot(N);

                        double aveE = (ball.Point.Elasticity * Points[i].Elasticity) / 2;

                        // v1'와 v2'를 구한다.
                        double f1 =
                            (((ball.Point.Mass -
                            (aveE * Points[i].Mass)) * velocity1) +
                            ((1 + aveE) * Points[i].Mass * velocity2)) /
                            (ball.Point.Mass + Points[i].Mass);

                        double f2 =
                            (((Points[i].Mass -
                            (aveE * ball.Point.Mass)) * velocity2) +
                            ((1 + aveE) * ball.Point.Mass * velocity1)) /
                            (ball.Point.Mass + Points[i].Mass);

                        ball.Point.Velocity = ball.Point.Velocity + N * (f1 - velocity1);
                        Points[i].Velocity = Points[i].Velocity + N * (f2 - velocity2);

                        // 가속도를 계산
                        Vector2D acc1 = ball.Point.Velocity / 1;
                        Vector2D acc2 = Points[i].Velocity / 1;
                        
                        ball.Point.ImpulseForce = ball.Point.ImpulseForce + acc1 * ball.Point.Mass;
                        Points[i].ImpulseForce = Points[i].ImpulseForce + acc2 * Points[i].Mass;
                        ball.Collision();
                    }
                }
            }
        }

        public void Update()
        {
            if (bRopeExist)
            {   
                RopeObj.Update();
            }
        }

        public void Render(Graphics g)
        {
            int TempY = viewportY;
            TempY = Math.Abs(viewportY) % backImg.Height;
            
            g.DrawImage(backImg, 0, 0, new Rectangle(0, -TempY, 200, backImg.Height), GraphicsUnit.Pixel);
            g.DrawImage(backImg, 0, TempY-backImg.Height, new Rectangle(0, 0, 200, backImg.Height), GraphicsUnit.Pixel);

            Pen newPen = new Pen(Color.Black);
            Pen newRopePen = new Pen(Color.GreenYellow);
            newRopePen.Width = 5;
            newRopePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            newRopePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            
            // Work place정의
            g.DrawRectangle(newPen, new Rectangle(0, height - 200, width-1, 200));
                        
            // 로프가 있다면
            if (bRopeExist)
            {
                Point newpoint = new Point();
                newpoint.X = (int)RopeObj.GetPoints()[0].Position.x;
                newpoint.Y = (int)RopeObj.GetPoints()[0].Position.y;


                for ( int i = 0; i < RopeObj.GetPoints().GetLength(0); i++ ) {
                    g.DrawLine(newRopePen, newpoint, new Point((int)RopeObj.GetPoints()[i].Position.x,
                        (int)RopeObj.GetPoints()[i].Position.y));
                    
                    newpoint.X = (int)RopeObj.GetPoints()[i].Position.x;
                    newpoint.Y = (int)RopeObj.GetPoints()[i].Position.y;
                                        
                }
            }

            newPen.Dispose();
            newRopePen.Dispose();

            Font newFont = new Font("aa",12);
            g.DrawString("높이 : " + Math.Abs(viewportY), newFont , Brushes.Black, 0, 0);
            newFont.Dispose();
        }

        public void BeginRope(int x, int y)
        {   
            if (y > height - 200)
            {
                bRopeExist = false;
                FromPoint.x = x;
                FromPoint.y = y;
            }
        }

        public void MovingRope(int x, int y)
        {
           
        }

        public void EndRope(int x, int y)
        {   
            ToPoint.x = x;
            ToPoint.y = y;
            double dist = FromPoint.Distance(ref ToPoint);

            if (y > height - 200)
            {                
                if (dist > 15)
                {
                    bRopeExist = true;
                    // 라인이 그려졌으면 라인을 n등분 하여 스프링 시스템으로 구성한다.
                    RopeObj.MakeRope(FromPoint, ToPoint, (int)(5 + 20 * (dist/200)));
                }
            }
            else
            {
                bRopeExist = false;
            }            
        }
    }
}
