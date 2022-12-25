using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace foreach_code
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            
            FileInfo[] filesinfo = dir.GetFiles();

            foreach (FileInfo each in filesinfo)
            {
                System.Console.WriteLine(each.Name);
            }            
        }
    }
}
