using System;
using System.Collections.Generic;
using System.Text;

namespace structProgram
{
    struct Data
    {
        public int A;
        public int B;
        public int C;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Data dat = new Data();
            
            System.Console.WriteLine(dat.A);
            System.Console.WriteLine(dat.B);
            System.Console.WriteLine(dat.C);
        }
    }
}
