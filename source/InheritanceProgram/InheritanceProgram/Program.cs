using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProgram
{
    class Animal
    {

    }

    class Person : Animal
    {
        protected string Name;
        protected int EyeType;
        protected int EarType;
        protected int MouthType;
        protected int NoseType;

        public void Print()
        {
            System.Console.WriteLine("이름 : " + Name);
            System.Console.WriteLine("눈 타입 : " + EyeType);
            System.Console.WriteLine("코 타입 : " + NoseType);
            System.Console.WriteLine("입 타입 : " + MouthType);
            System.Console.WriteLine("귀 타입 : " + EarType);
        }
    }

    class Cyborg : Person
    {
        public int Power;


        public void Set(string name, int eye, int ear, int mouth, int nose)
        {
            Name = name;
            EyeType = eye;
            EarType = ear;
            MouthType = mouth;
            NoseType = nose;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cyborg Smith = new Cyborg();
            //Smith.Set("스미스", 1 , 20, 2 , 3);
            Smith.Name = "스미스";
            Smith.Print();
        }
    }
}
