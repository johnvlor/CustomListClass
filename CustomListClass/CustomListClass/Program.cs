﻿using System;
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
            //MyList<int> myList = new MyList<int>();
            //Console.WriteLine(myList.Count());

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

            //int num = 10;

            //for (int i = 0; i < num; i++)
            //{
            //    myList.Add(i);
            //}

            //Console.WriteLine(myList[0]);
            //Console.WriteLine(myList[1]);
            //Console.WriteLine(myList[2]);
            //Console.WriteLine(myList[3]);
            //Console.WriteLine(myList[4]);
            //Console.WriteLine(myList[5]);
            //Console.WriteLine(myList[6]);
            //Console.WriteLine(myList[7]);
            //Console.WriteLine(myList[8]);
            //Console.WriteLine(myList[9]);
            //Console.WriteLine("Count " + myList.Count);
            //Console.WriteLine(myList.ToString());

            //myList.Remove(1);
            //myList.Remove(2);
            //myList.Remove(7);
            //myList.Remove(9);
            //Console.WriteLine("Count " + myList.Count);
            //Console.WriteLine(myList.ToString());

            //MyList<string> myStringList = new MyList<string>();

            //myStringList.Add("DaddyFinger");
            //myStringList.Add("MommyFinger");
            //myStringList.Add("BabyFinger");

            //Console.WriteLine(myStringList[0]);
            //Console.WriteLine(myStringList[1]);
            //Console.WriteLine(myStringList[2]);
            //string newStringResult;

            //newStringResult = myStringList.ToString();
            //Console.WriteLine(newStringResult);

            //myStringList.Remove("DaddyFinger");
            //newStringResult = myStringList.ToString();
            //Console.WriteLine(newStringResult);


            //MyList<int> myNewList = new MyList<int>() { 0, 1, 2, 3, 4, 5 };
            //Console.WriteLine(myNewList.Count);
            ////Console.WriteLine(myNewList[4]);
            ////Console.WriteLine(myNewList[5]);
            ////Console.WriteLine(myNewList[2]);
            ////string newResult;

            ////newResult = myNewList.ToString();
            ////Console.WriteLine(newResult);

            MyList<int> myListOne = new MyList<int>() { 0, 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(myListOne.Count);
            MyList<int> myListTwo = new MyList<int>() { 6, 7, 8, 9, 10 };
            MyList<int> myListThree = new MyList<int>() { 11, 12, 13, 14, 15, 16, 17 };

            MyList<int> resultList = new MyList<int>();
            resultList = (myListOne + myListTwo) + myListThree;

            Console.WriteLine("result list " + resultList.ToString());
            Console.WriteLine(resultList.Count);
            Console.WriteLine(resultList[14]);

            for (int i = 0; i < resultList.Count; i++)
            {
                Console.WriteLine(i + 1 + " " + resultList[i]);
            }

            int value = 0;
            foreach (int number in resultList)
            {
                Console.WriteLine("iterator "+number);
                value = number;
            }

            Console.WriteLine(value);

            MyList<int> myListFour = new MyList<int>() { 0, 1, 2, 3, 4, 5, 100 };
            Console.WriteLine(myListFour[0]);
            MyList<int> myListFive = new MyList<int>() { 1, 3, 5 };
            MyList<int> myListSix = new MyList<int>() { 2, 4};
            resultList = myListFour + myListFive;
            Console.WriteLine(resultList[0]);
            resultList = (myListFour - myListFive) - myListSix;
            Console.WriteLine(resultList[0]);
            Console.WriteLine("result list " + resultList.ToString());
            Console.WriteLine(resultList.Count);

            for (int i = 0; i < resultList.Count; i++)
            {

                Console.WriteLine(i+1 + " " + resultList[i]);
            }

            Console.ReadKey();

        }
    }
}
