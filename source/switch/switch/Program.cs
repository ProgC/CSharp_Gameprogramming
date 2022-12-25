using System;
using System.Collections.Generic;
using System.Text;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // A형 0
            // B형 1
            // AB형 2
            // O형 3

            int BloodType = 1;

            switch (BloodType)
            {
                case 0:
                    System.Console.WriteLine("A형입니다.");
                break;

                case 1:
                    System.Console.WriteLine("B형입니다.");
                break;

                case 2:
                    System.Console.WriteLine("AB형입니다.");
                break;
                    
                case 3:
                    System.Console.WriteLine("O형입니다.");
                break;
            }
        }
    }
}
