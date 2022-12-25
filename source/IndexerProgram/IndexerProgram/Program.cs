using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace IndexerProgram
{
    class SimpleIntVector
    {
        private ArrayList data = new ArrayList();

        public void push_back(int ndata)
        {
            data.Add(ndata);
        }

        public int GetData(int nIndex)
        {
            return (int)data[nIndex];
        }

        public int this[int nIndex]
        {
            get
            {
                return (int)data[nIndex];                
            }
            set
            {
                if (nIndex >= data.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                data[nIndex] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleIntVector vecData = new SimpleIntVector();

            vecData.push_back(1);
            vecData.push_back(2);
            vecData.push_back(5);
            vecData.push_back(10);

            System.Console.WriteLine("{0} ", vecData[2]);

            vecData[2] = 99;

            System.Console.WriteLine("{0} ", vecData[2]);
        }
    }
}
