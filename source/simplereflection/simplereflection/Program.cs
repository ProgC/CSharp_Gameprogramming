using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace simpleattribute
{
    class Program
    {
        class Player
        {
            public void Punch()
            {
                System.Console.WriteLine("Punch!");
            }
            public void Kick()
            {
                System.Console.WriteLine("Kick!");
            }
            public void Finger()
            {
                System.Console.WriteLine("Finger!");
            }
        }

        class PlayerExtend : Player
        {
            public void Head()
            {
                System.Console.WriteLine("Head!");
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            PlayerExtend playerEx = new PlayerExtend();

            Type type = playerEx.GetType();
            MethodInfo[] info = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            System.Console.WriteLine("Method count : " + info.GetLength(0));

            /*foreach (MethodInfo info in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                System.Console.WriteLine(info.Name);
            }*/
        }
    }
}
