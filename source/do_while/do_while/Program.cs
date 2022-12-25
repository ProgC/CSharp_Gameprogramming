using System;
using System.Collections.Generic;
using System.Text;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                System.Console.WriteLine(i + "번째");
                i++;
            } while (i < 10);
        }
    }
}
