using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace HashtableProgram
{
    class GameUser
    {
        public string Name;
        public int Energy;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Table = new Hashtable();

            GameUser gam1 = new GameUser();
            gam1.Name = "C#유저";
            gam1.Energy = 100;

            GameUser gam2 = new GameUser();
            gam2.Name = "홍길동";
            gam2.Energy = 60;

            GameUser gam3 = new GameUser();
            gam3.Name = "카일 스나스";
            gam3.Energy = 120;

            Table.Add(gam1.Name.GetHashCode(), gam1);
            Table.Add(gam2.Name.GetHashCode(), gam2);
            Table.Add(gam3.Name.GetHashCode(), gam3);

            /*ICollection keys = Table.Keys;
            
            foreach (int key in keys)
            {
                System.Console.WriteLine(key);
            }*/

            /*ICollection value = Table.Values;

            foreach (object obj in value)
            {
                GameUser GetPlayer = (GameUser)obj;
                System.Console.WriteLine(GetPlayer.Name);
                System.Console.WriteLine(GetPlayer.Energy);
            }*/

            GameUser GetPlayer = (GameUser)Table["C#유저".GetHashCode()];
            if (GetPlayer != null)
            {
                System.Console.WriteLine(GetPlayer.Name);
                System.Console.WriteLine(GetPlayer.Energy);
            }
            else
            {
                System.Console.WriteLine("유저를 찾지 못하였습니다.");
            }
        }
    }
}
