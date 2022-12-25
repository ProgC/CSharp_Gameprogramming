using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace simpleattribute
{
    class Program
    {
        class CustomMethod : Attribute
        {
            public CustomMethod(string name)
            {
                methodname = name;
            }

            public string GetName()
            {
                return methodname;
            }

            private string methodname;
        }
                
        class Player
        {
            [CustomMethod("Punch")]
            public void Punch()
            {
                System.Console.WriteLine("Punch!");
            }
            [CustomMethod("Kick")]
            public void Kick()
            {
                System.Console.WriteLine("Kick!");
            }
            [CustomMethod("Finger")]
            public void Finger()
            {
                System.Console.WriteLine("Finger!");
            }
        }

        class PlayerExtend : Player
        {
            [CustomMethod("Head")]
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

            foreach (MethodInfo info in type.GetMethods())
            {                
                foreach (Attribute attr in info.GetCustomAttributes(true))
                {
                    if (attr is CustomMethod)
                    {
                        System.Console.WriteLine(info.Name);
                    }
                }
            }
        }
    }
}
