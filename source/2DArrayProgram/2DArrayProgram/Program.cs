using System;
using System.Collections.Generic;
using System.Text;

namespace _DArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] TwoMap = new int[5, 10] {
                {0,0,0,0,1,1,0,0,0,0},
                {0,0,0,1,0,0,1,0,0,0},
                {0,0,0,1,0,0,1,0,0,0},
                {0,0,0,1,0,0,1,0,0,0},
                {0,0,0,0,1,1,0,0,0,0},                
            };

            for (int y = 0; y < TwoMap.GetLength(0); y++)
            {
                for (int x = 0; x < TwoMap.GetLength(1); x++)
                {
                    System.Console.Write(TwoMap[y, x]);                                        
                }
                System.Console.WriteLine();
            }
        }
    }
}
