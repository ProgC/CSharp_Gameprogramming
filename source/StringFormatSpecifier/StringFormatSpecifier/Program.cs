using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StringFormatSpecifier
{
    class Record
    {
        public int number;
        public string name;
        public string address;
        public string addressB;
        public string type;

        public void PrintAll()
        {
            System.Console.Write("{0,8:D8} {1,-10}\t {2,-10}", number, name, address);
            System.Console.WriteLine();
        }
    }

    class Program
    {        
        static void Main(string[] args)
        {
            ArrayList lst = new ArrayList();
            
            Record rec = new Record();
            rec.number = 26698;
            rec.name = "김상한";
            rec.address = "380-011충청북도 충주시 일번동";
            rec.addressB = "5번지 4통 4반";
            rec.type = "케이블고급형";

            lst.Add( rec );

            // 나머지 생략

            rec = new Record();
            rec.number = 24692;
            rec.name = "백수건설";
            rec.address = "369-014충청북도 음성군 사번동";
            rec.addressB = "264번지 백수건설";
            rec.type = "케이블보급형";

            lst.Add(rec);

            foreach (Record each in lst)
            {
                each.PrintAll();
            }            
        }
    }
}
