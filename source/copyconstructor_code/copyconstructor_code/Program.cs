using System;
using System.Collections.Generic;
using System.Text;

namespace copyconstructor_code
{
    class Character
    {
        public string Name;
        public int Level = 1;
        public int Energy = 30;

        public Character(string Name, int Level, int Energy)
        {
            this.Name = Name;
            this.Level = Level;
            this.Energy = Energy;
        }

        public Character(Character obj)
        {
            Name = obj.Name;
            Level = obj.Level;
            Energy = obj.Energy;
        }

      

        public void PrintName()
        {
            System.Console.WriteLine("이름 : " + Name);
        }
        public void PrintLevel()
        {
            System.Console.WriteLine("레벨 : " + Level);
        }
        public void PrintEnergy()
        {
            System.Console.WriteLine("에너지 : " + Energy);
        }

        public void PrintAllInformation()
        {
            PrintName();
            PrintLevel();
            PrintEnergy();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Character Knight = new Character("기사", 10, 100);
            
            // 객체를 복사한다.
            Character SecondKnight = new Character(Knight);

            // 원본 기사의 레벨을 변경한다.
            Knight.Level = 11;

            Knight.PrintAllInformation();
            SecondKnight.PrintAllInformation();
        }
    }
}
