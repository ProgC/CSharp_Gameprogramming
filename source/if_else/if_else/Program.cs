using System;
using System.Collections.Generic;
using System.Text;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int nEnergyOfCharacter = 5;
            if ( nEnergyOfCharacter > 2)
                System.Console.WriteLine("케릭터의 에너지가 2보다 큽니다.");
            else
                System.Console.WriteLine("케릭터의 에너지가 2보다 작습니다.");
                System.Console.WriteLine("전투를 하면 이길 확률이 크겠군요.");*/

            // 중첩된 if문
            Random r = new Random();
            int nA = 100;
            int nB = r.Next() % 100;

            if (nA == 100)
            {
                System.Console.WriteLine("nA는 100입니다.");

                if (nB > 80)
                {
                    System.Console.WriteLine("nB는 80초과입니다.");                    
                }
                else
                {
                    System.Console.WriteLine("nB는 80이하입니다.");
                }
            }
            else
            {
                System.Console.WriteLine("nA는 100이 아닙니다.");
                System.Console.WriteLine("nB가 어떻게 되던 관심이 없습니다.");
            }
        }
    }
}
