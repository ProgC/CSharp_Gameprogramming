using System;
using System.Collections.Generic;
using System.Text;

namespace Function_Code
{
    class CGameEntity
    {
        public string Name;
        public int level;
        public int str;
        public int dex;
        public int rec;
        public int [] Items = new int[100];
    }

    class Program
    {
        public static void PrintText()
        {
            System.Console.WriteLine("PrintText함수가 호출 되었습니다.");
        }

        public static int Func(int x)
        {
            return x * x;
        }

        public static void FuncB(int x)
        {
            x = 20;
        }

        /*static void Main(string[] args)
        {
            int Y = Func(2);
            System.Console.WriteLine("Y값은 " + Y + "입니다.");
        }*/

        public static void CallByValue(int x)
        {
            int TempX = x;
            TempX = 10;
        }
        public static void CallByRef(ref int x)
        {
            x = 10;
        }

        // 레벨이 10이상이라면 true를 반환하고 아니면 false를 반환한다.
        public static bool LevelCheck(ref CGameEntity obj)
        {
            if (obj.level >= 10) return true;
            return false;
        }

        static void Main(string[] args)
        {
            CGameEntity obj = new CGameEntity();

            obj.level = 10;
            if (LevelCheck(ref obj))
            {
                System.Console.WriteLine("레벨이 10 이상입니다.");
            }
            else
            {
                System.Console.WriteLine("레벨이 10 미만입니다.");
            }
        }
    }
}
