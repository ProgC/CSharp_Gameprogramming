using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMemberProgram
{
    class Monster
    {
        public static int nCount;
        public string Name;
        public int Energy;

        public Monster()        
        {
            nCount++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Monster mob1 = new Monster();
            mob1.Name = "푸푸";
            mob1.Energy = 10;

            Monster mob2 = new Monster();
            mob2.Name = "사비";
            mob2.Energy = 20;
            
            System.Console.WriteLine("이름 : {0} 에너지 : {1}", mob1.Name, mob1.Energy);
            System.Console.WriteLine("이름 : {0} 에너지 : {1}", mob2.Name, mob2.Energy);

            System.Console.WriteLine("만들어진 몬스터 개수 : {0}", Monster.nCount);
        }
    }
}
