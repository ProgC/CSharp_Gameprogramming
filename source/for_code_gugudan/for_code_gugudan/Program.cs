using System;
using System.Collections.Generic;
using System.Text;

namespace for_code_gugudan
{
    class Program
    {
        static void Main(string[] args)
        {
            int nDan = 2;

            for (int i = 1; i <= 9; i++)
            {
                System.Console.WriteLine("{0} X {1} = {2}", nDan, i, nDan * i);
            }
        }
    }
}
