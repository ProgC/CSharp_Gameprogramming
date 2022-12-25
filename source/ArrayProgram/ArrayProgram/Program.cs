using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ArrayProgram
{
    class GameObject
    {
        public string Name;

        public void PrintName()
        {
            System.Console.WriteLine("이름 : " + Name);
        }
        public void Update()
        {
            System.Console.WriteLine(Name + "가 무언가를 한다");
        }

        public void Render()
        {
            // 화면에 gameobject를 그린다.
            System.Console.WriteLine("화면에 " + Name + " 을 그린다");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GameObject objA = new GameObject();
            GameObject objB = new GameObject();
            GameObject objC = new GameObject();
            GameObject objD = new GameObject();

            objA.Name = "스미스";
            objB.Name = "푸푸";
            objC.Name = "C#언어";
            objD.Name = "카일 스나스";

            GameObject[] objlist = new GameObject[4] { objA, objB, objC, objD };


            bool bLoop = true;
            while (bLoop)
            {
                Thread.Sleep(1000);

                for (int i = 0; i < 4; i++)
                {
                    objlist[i].Update();
                    objlist[i].Render();
                    objlist[i].PrintName();
                }
            }
        }
    }
}
