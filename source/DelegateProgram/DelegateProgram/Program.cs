using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace DelegateProgram
{    
    class Program
    {
        public delegate int Print(string msg);

        public static int SpeakA(string msg)
        {
            System.Console.Write("A가 말하길 ");
            System.Console.WriteLine(msg);
            return 0;
        }

        public static int SpeakB(string msg)
        {
            System.Console.Write("B가 말하길 ");
            System.Console.WriteLine(msg);
            return 1;
        }
                   

        static void Main(string[] args)
        {
            Print A = new Print(SpeakA);
            Print B = new Print(SpeakB);
            Print C;


            Random r = new Random();
            if (r.Next(100) > 50)
            {
                C = A;
            }
            else
            {
                C = B;
            }
            C("안녕");
        }
    }
}
