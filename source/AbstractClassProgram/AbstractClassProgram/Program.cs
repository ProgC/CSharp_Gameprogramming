using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassProgram
{
    abstract class Animal
    {
        abstract public void Eat();
    }

    class Person : Animal
    {
        public override void Eat()
        {
            System.Console.WriteLine("사람은 밥을 먹습니다.");            
        }
    }

    class Cyborg : Person
    {
        public override void Eat()
        {
            System.Console.WriteLine("사이보그는 전기를 먹습니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.Eat();

            Cyborg objB = new Cyborg();
            objB.Eat();
        }
    }
}
