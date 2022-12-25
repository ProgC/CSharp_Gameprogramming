using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverload
{
    struct CVector
    {
        private float x;
        private float y;

        public CVector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public void Subtraction( CVector b )
        {
            x -= b.X;
            y -= b.Y;
        }

        public static CVector operator-(CVector lhs, CVector rhs)
        {
            return new CVector(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }
        
        
        // 테스트용
        public void PrintAll()
        {
            System.Console.WriteLine("X = {0}, Y = {1}", x, y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CVector A = new CVector(10,10);
            A.PrintAll();

            CVector B = new CVector(100, 100);
            B.PrintAll();

            CVector C = B - A;
            C.PrintAll();

            //B -= A;
            //B.PrintAll();
        }
    }
}
