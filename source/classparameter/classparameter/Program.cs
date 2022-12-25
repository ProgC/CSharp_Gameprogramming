using System;
using System.Collections.Generic;
using System.Text;

namespace classparameter
{
    class CData
    {
        public int A;
        public int B;
    }

    class Program
    {
        static void Calc(CData obj)
        {
            obj.A = 100;
            obj.B = 200;
        }


        static void Main(string[] args)
        {
            CData obj = new CData();
            obj.A = 10;
            obj.B = 20;

            System.Console.WriteLine("초기값");
            System.Console.WriteLine("A 는 " + obj.A);
            System.Console.WriteLine("B 는 " + obj.B);

            Calc(obj);

            System.Console.WriteLine("함수 결과");
            System.Console.WriteLine("A 는 " + obj.A);
            System.Console.WriteLine("B 는 " + obj.B);
        }
    }
}
