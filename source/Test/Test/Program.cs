using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Program
    {
        enum AMOR_TYPE
        {
            CYellowAmor = 10,
            cRedAmor = 30
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Byte : " + sizeof(Byte) + " MaxLength " + Byte.MaxValue);
            System.Console.WriteLine("Char : " + sizeof(Char) + " MaxLength " + Char.MaxValue);
            System.Console.WriteLine("Boolean : " + sizeof(Boolean) + " MaxLength " );
            System.Console.WriteLine("SByte : " + sizeof(SByte) + " MaxLength " + SByte.MaxValue);
            System.Console.WriteLine("Int16 : " + sizeof(Int16) + " MaxLength " + Int16.MaxValue + " MinLength " + Int16.MinValue);
            System.Console.WriteLine("UInt16 : " + sizeof(UInt16) + " MaxLength " + UInt16.MaxValue);
            System.Console.WriteLine("Int32 : " + sizeof(Int32) + " MaxLength " + Int32.MaxValue + " MinLength " + Int32.MinValue);
            System.Console.WriteLine("Uint32 : " + sizeof(UInt32) + " MaxLength " + UInt32.MaxValue);
            System.Console.WriteLine("Single : " + sizeof(Single) + " MaxLength " + Single.MaxValue);
            System.Console.WriteLine("Double : " + sizeof(Double) + " MaxLength " + Double.MaxValue);
            System.Console.WriteLine("Decimal : " + sizeof(Decimal) + " MaxLength " + Decimal.MaxValue);
            System.Console.WriteLine("Int64 : " + sizeof(Int64) + " Maxlength " + Int64.MaxValue);
            System.Console.WriteLine("Uint64 : " + sizeof(UInt64) + " MaxLength " + UInt64.MaxValue);


            //float PI = 3.141593F;
            //int PI_Int = (int)PI;
            //System.Console.WriteLine("PI = " + PI);
            //System.Console.WriteLine("PI_Int = " + PI_Int);

            
            String strText = "텍스트";
            int Data = 1234;
            strText += Convert.ToString(Data);
            System.Console.WriteLine(strText);

          //  const double PI = 3.1415926535897;


            /*int nData = 10;
            int nMod = nData % 3;
            System.Console.WriteLine("나머지 : " + nMod);

            Random r = new Random();
            int nResult = r.Next() % 100;
            if (nResult >= 60)
            {
         //       ActionKick();
            }

            System.Console.WriteLine(0 % 100);*/

            /*Random r = new Random();
            int nData = r.Next();
            int nResult = nData % 2;
            if (nResult == 0)
            {
                System.Console.WriteLine(nData + "는 2의 배수입니다.");
            }
            else
            {
                System.Console.WriteLine(nData + "는 2의 배수가 아닙니다.");
            }


            nData++;*/

            //Byte nAge = 1;
            //Byte CurrentAge = nAge++;
            //System.Console.WriteLine("현재 나이는 " + CurrentAge);
            
            Byte nA = 66;
            Byte nB = 44;

            if (nA == 66 || nB == 33)
            {
                System.Console.WriteLine("Action");
            }

            Boolean bLoop = false;
            Boolean bResult = !bLoop;


            Boolean bAlive = true;

            if ( !bAlive )
            {
                System.Console.WriteLine("hi");
            }
        }
    }
}
