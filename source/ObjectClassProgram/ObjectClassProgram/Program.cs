using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectClassProgram
{
    class CData
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            System.Console.WriteLine("Hashcode is " + a.GetHashCode());

            System.Console.WriteLine("HashCode is " + "Hello".GetHashCode());            
        }
    }
}
