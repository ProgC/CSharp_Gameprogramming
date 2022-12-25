using System;
using System.Collections.Generic;
using System.Text;

namespace CallByValue
{
    class Program
    {
        static int GetValue(ref int x)
        {
            x++;
            return x;
        }

        static void Main(string[] args)
        {
            int nParam = 20;
            int nReturn = GetValue(ref nParam);

            System.Console.WriteLine("nParam = " + nParam);
            System.Console.WriteLine("nReturn = " + nReturn);
        }
    }
}
