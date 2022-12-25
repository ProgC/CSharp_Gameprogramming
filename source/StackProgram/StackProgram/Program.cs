using System;
using System.Collections.Generic;
using System.Text;

namespace StackProgram
{
    class Program
    {
        // 스택에 들어 있는 모든 요소들을 화면에 출력한다.
        static void PrintAll(IEnumerator<int> p)
        {
            p.Reset();
            System.Console.Write("Stack Data => ");
            while (p.MoveNext())
            {
                System.Console.Write("{0} " ,p.Current);
            }
            System.Console.WriteLine();
        }

        static void Main(string[] args)
        {            
            Stack<int> sData = new Stack<int>();

            sData.Push(3);
            sData.Push(2);
            sData.Push(1);
         
            // 값 출력               
            PrintAll(sData.GetEnumerator());

            sData.Push(9);
            PrintAll(sData.GetEnumerator());

            sData.Push(10);
            PrintAll(sData.GetEnumerator());

            int rtnValue = sData.Pop();
            System.Console.WriteLine("Pop : {0}", rtnValue);
            PrintAll(sData.GetEnumerator());

            rtnValue = sData.Pop();
            System.Console.WriteLine("Pop : {0}", rtnValue);
            PrintAll(sData.GetEnumerator());
        }
    }
}
