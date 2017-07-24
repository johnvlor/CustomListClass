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

            Console.WriteLine("Count " + myList.Count());
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            Console.WriteLine("Count " + myList.Count());
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            Console.WriteLine("Count " + myList.Count());
            myList.Add(25);

            //Console.WriteLine(myList[0]);
            //Console.WriteLine(myList[1]);
            //Console.WriteLine(myList[2]);
            //Console.WriteLine(myList[3]);
            //Console.WriteLine(myList[4]);
            //Console.WriteLine(myList[5]);
            //Console.WriteLine(myList[6]);
            //Console.WriteLine(myList[7]);
            //Console.WriteLine(myList[8]);
            Console.WriteLine("Count "+myList.Count());

            Console.ReadKey();

        }
    }
}
