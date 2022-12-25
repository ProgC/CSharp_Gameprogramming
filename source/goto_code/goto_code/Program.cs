using System;
using System.Collections.Generic;
using System.Text;

namespace goto_code
{
    class Program
    {
        static void Main(string[] args)
        {

            int nA = 100;

jmp_here:
            if (nA == 100)
            {
                System.Console.WriteLine("nA는 100입니다.");
                nA = 200;
                goto jmp_here;
            }
            else
            {
                System.Console.WriteLine("이 코드는 실행이 될 수 없습니다.");
                System.Console.WriteLine("nA는 100이 아닙니다.");
            }
        }
    }
}
