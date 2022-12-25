using System;
using System.Collections.Generic;
using System.Text;

namespace SawtoothArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] MySawToothArray = new int[5][];

            MySawToothArray[0] = new int[10];
            MySawToothArray[1] = new int[5];
            MySawToothArray[2] = new int[8];
            MySawToothArray[3] = new int[2];
            MySawToothArray[4] = new int[7];

            for (int i = 0; i < MySawToothArray.GetLength(0); i++)
            {
                System.Console.WriteLine("==========");
                System.Console.WriteLine("{0}번째 행", i);
                for (int j = 0; j < MySawToothArray[i].Length; j++)
                {
                    System.Console.Write("{0} ", MySawToothArray[i][j]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
