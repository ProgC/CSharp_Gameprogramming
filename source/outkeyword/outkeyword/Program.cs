using System;
using System.Collections.Generic;
using System.Text;

namespace outkeyword
{
    class Program
    {
        static int GetValue(out int x)
        {
            x = 10;
            return x;
        }

        static void Main(string[] args)
        {
            int nParam;
            int nReturn = GetValue(out nParam);

            System.Console.WriteLine("nParam = " + nParam);
            System.Console.WriteLine("nReturn = " + nReturn);
        }
    }
}
