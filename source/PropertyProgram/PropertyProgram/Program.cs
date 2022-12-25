using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyProgram
{
    class CData
    {
        public int nData;

        public int Data
        {
            get
            {
                return nData;
            }
            set
            {
                // Log남기기
                System.Console.WriteLine("값이 수정됩니다. 이전값 " + nData + "에서");
                nData = value;
                System.Console.WriteLine(nData + "으로 수정되었습니다.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CData obj = new CData();            
            System.Console.WriteLine("현재 값 " + obj.Data);
            obj.Data = 10;            
            System.Console.WriteLine("현재 값 " + obj.Data);
        }
    }
}
