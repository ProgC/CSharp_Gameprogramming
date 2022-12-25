using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;

namespace PolymorphismProgram
{
    sealed class Animal
    {
        public string name;
        
        public virtual void Eat()
        {
            System.Console.WriteLine(name + " 은 밥을 먹습니다.");
        }
    }

    class Person : Animal
    {
        
        
    }
    
    class Cyborg : Person
    {

        public override void Eat()
        {
            base.Eat();
            System.Console.WriteLine(name + "은 전력을 먹고 삽니다~");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList peoplelist = new ArrayList();
            
            Person friendA = new Person();
            friendA.name = "은숙이";

            Person friendB = new Person();
            friendB.name = "미스터 앤더슨";

            Person friendC = new Person();
            friendC.name = "부모님께 효도하는 효도르";
            
            Cyborg Smith = new Cyborg();
            Smith.name = "스미스";

            peoplelist.Add(friendA);
            peoplelist.Add(friendB);
            peoplelist.Add(friendC);
            peoplelist.Add(Smith);

            bool bLoop = true;
            while (bLoop)
            {
                Thread.Sleep(1000);

                for (int i = 0; i < peoplelist.Count; i++)
                {
                    // 우선은 모든 사람들의 밥먹는 시간대가 똑같다고 가정합니다.
                    ((Animal)peoplelist[i]).Eat();
                }
            }
        }
    }
}
