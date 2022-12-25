using System;
using System.Collections.Generic;
using System.Text;

namespace class_code
{
    public class Character
    {
        private string Name;
        private int Level;
        private int Energy = 100;

        // 기본 생성자
        public Character()
        {
        }

        public Character(string name_, int level_, int energy_)
        {
            Name = name_;
            Level = level_;
            Energy = energy_;
        }
        public void SetName(string name_)
        {
            Name = name_;
        }
        public void SetLevel(int level_)
        {
            Level = level_;
        }
        public void SetEnergy(int energy_)
        {
            Energy = energy_;
        }
        public string GetName()
        {
            return Name;
        }
        public int GetLevel() 
        {
            return Level;
        }
        public int GetEnergy()
        {
            return Energy;
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
            Character Knight = new Character("기사",1,10);
            Character Wizard = new Character("마법사",2,5);
            Character PersonA = new Character("지나가는 행인",1,100);
            Character PersonB = new Character("지나가다가 멈춘 행인", 1, 100);
            Character PersonC = new Character("지나가려는 행인", 1, 100);

  
           /* Knight.SetName( "기사" );
            Knight.SetLevel(1);
            Knight.SetEnergy(10);

            Wizard.SetName("마법사");
            Wizard.SetLevel(2);
            Wizard.SetEnergy(5);

            PersonA.SetName("지나가는 행인");
            PersonA.SetLevel(1);

            PersonB.SetName("지나가다가 멈춘 행인");
            PersonB.SetLevel(1);

            PersonC.SetName("지나가려는 행인");
            PersonC.SetLevel(1);*/

            Knight.PrintAllInformation();
            Wizard.PrintAllInformation();
            PersonA.PrintAllInformation();
            PersonB.PrintAllInformation();
            PersonC.PrintAllInformation();

            
        }
    }
}
