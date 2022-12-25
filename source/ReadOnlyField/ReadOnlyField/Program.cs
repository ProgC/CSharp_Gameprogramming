using System;
using System.Collections.Generic;
using System.Text;

namespace ReadOnlyField
{
    class Program
    {
        public readonly int nData;

        public Program()
        {
            nData = 20;
            System.Console.WriteLine("nData : " + nData);
        }
        
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.nData = 30;
            System.Console.WriteLine("nData : " + nData);
        }
    }
}
