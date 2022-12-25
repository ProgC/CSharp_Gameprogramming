using System;
using System.Collections.Generic;
using System.Text;

namespace while_code
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;

            /*while (i < 100)
            {
                System.Console.WriteLine("현재 나이 : " + i);
                i++;
            }*/


            bool bExit = false;

            while (!bExit)
            {
                // 어떠한 로직 수행, 루프를 끝내고 싶을 때 bExit를 true로 설정
            }

            bool bLoop = true;

            while ( bLoop )
            {
                // 어떠한 로직을 수행, 루프를 끝내고 싶을 때 bLoop를 false로 설정
            }
        }
    }
}
