using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Graphics_DrawTriangleWithColorInterpolation
{
    struct ColorVertex
    {
        public int x;
        public int y;
        public int r;
        public int g;
        public int b;

        public void SetPosition(int x_, int y_)
        {
            x = x_;
            y = y_;
        }

        public void SetColor( int r_, int g_, int b_ )
        {
            r = r_;
            g = g_;
            b = b_;
        }
    }

    class Triangle2D
    {
        public ColorVertex A;
        public ColorVertex B;
        public ColorVertex C;
        private Bitmap bmOnePixel = new Bitmap(1, 1);
        
        public Triangle2D( int x1, int y1,
                                int x2, int y2,
                                int x3, int y3,
                                int r1, int g1, int b1,
                                int r2, int g2, int b2,
                                int r3, int g3, int b3)
        {
            A.SetPosition(x1, y1);
            B.SetPosition(x2, y2);
            C.SetPosition(x3, y3);
            
            // 컬러 설정
            A.SetColor( r1, g1, b1 );
            B.SetColor( r2, g2, b2 );
            C.SetColor( r3, g3, b3 );

            bmOnePixel.SetPixel(0, 0, Color.Black);
        }

        public void DrawBottomTriangle(Graphics g, Triangle2D tri)
        {
            // 반드시 c가 a보다 큰 값을 가지고 있다.
            int height = C.y - A.y;
            double lm = (B.y - A.y) / (double)(B.x - A.x);
            double rm = (C.y - A.y) / (double)(C.x - A.x);
            double lcx;
            double rcx;

            for (int y = A.y; y < A.y + height; y++)
            {
                lcx = (y - B.y) / lm + B.x;
                rcx = (y - C.y) / rm + C.x;

                // 왼쪽 스캔 라인의 색상
                double lr = ((A.y - y) * B.r + (y - B.y) * A.r) / (A.y - B.y);
                double lg = ((A.y - y) * B.g + (y - B.y) * A.g) / (A.y - B.y);
                double lb = ((A.y - y) * B.b + (y - B.y) * A.b) / (A.y - B.y);

                // 오른쪽 스캔 라인의 색상
                double rr = ((A.y - y) * C.r + (y - C.y) * A.r) / (A.y - B.y);
                double rg = ((A.y - y) * C.g + (y - C.y) * A.g) / (A.y - B.y);
                double rb = ((A.y - y) * C.b + (y - C.y) * A.b) / (A.y - B.y);
                
                for (int x = (int)lcx; x < (int)rcx; x++)
                {
                    double interR = ((rcx - x) * lr + (x - lcx) * rr) / (rcx - lcx);
                    double interG = ((rcx - x) * lg + (x - lcx) * rg) / (rcx - lcx);
                    double interB = ((rcx - x) * lb + (x - lcx) * rb) / (rcx - lcx);

                    bmOnePixel.SetPixel(0, 0, Color.FromArgb((byte)interR, (byte)interG, (byte)interB));
                    g.DrawImage(bmOnePixel, x, y);
                }
            }
        }

        public void Draw(Graphics g)
        {
            // 하변이 평평한 삼각형을 그리는 예
            DrawBottomTriangle(g, new Triangle2D(A.x, A.y, B.x, B.y, C.x, C.y,
                                               A.r, A.g, A.b,
                                               B.r, B.g, B.b,
                                               C.r, C.g, C.b));
        }
    }
}
