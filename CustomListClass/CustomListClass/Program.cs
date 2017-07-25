using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            //Console.WriteLine("Count " + myList.Count());
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //Console.WriteLine("Count " + myList.Count());
            //myList.Add(4);
            //myList.Add(5);
            //myList.Add(6);
            //myList.Add(7);
            //Console.WriteLine("Count " + myList.Count());
            //myList.Add(8);
            //myList.Add(9);
            //Console.WriteLine("Count " + myList.Count());

            int num = 10;
            int result = 9;

            for (int i = 0; i < num; i++)
            {
                myList.Add(i);
            }

            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);
            Console.WriteLine(myList[2]);
            Console.WriteLine(myList[3]);
            Console.WriteLine(myList[4]);
            Console.WriteLine(myList[5]);
            Console.WriteLine(myList[6]);
            Console.WriteLine(myList[7]);
            Console.WriteLine(myList[8]);
            Console.WriteLine(myList[9]);
            Console.WriteLine("Count " + myList.Count());

            MyList<string> myStringList = new MyList<string>();

            myStringList.Add("DaddyFinger");
            myStringList.Add("MommyFinger");
            myStringList.Add("BabyFinger");

            Console.WriteLine(myStringList[0]);
            Console.WriteLine(myStringList[1]);
            Console.WriteLine(myStringList[2]);
            string newStringResult;

            newStringResult = myStringList.ToString();
            Console.WriteLine(newStringResult);

            //MyList<int> newList = new MyList<int>() { 0, 1, 2, 3, 4, 5 };
            string newResult;

            newResult = myList.ToString();
            Console.WriteLine(newResult);

            Console.ReadKey();

        }
    }
}
