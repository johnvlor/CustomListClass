using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class MyList<T>
    {
        T[] arrayList;
        int arraySize;
        int arrayCapacity;

        public T this[int index]
        {
            get
            {
                return arrayList[index];
            }
            set
            {
                arrayList[index] = value;
            }
        }

        public MyList()
        {
            arraySize = 0;
            arrayCapacity = 0;
            arrayList = new T[arraySize];
        }

        public MyList(T[] arrayList)
        {
            arraySize = 0;
            arrayCapacity = 0;
            this.arrayList = arrayList;
        }

        public void Add(T item)
        {
            if (arraySize == arrayCapacity)
            {
               if (arrayCapacity == 0)
                {
                    arrayCapacity = 2;
                }
               else
                {
                    arrayCapacity = arrayCapacity * 2;
                }

                T[] tempArray = new T[arrayCapacity];

                for (int i = 0; i < arraySize; i++)
                {
                    tempArray[i] = arrayList[i];
                }
                arrayList = tempArray;
            }

            arrayList[arraySize] = item;
            arraySize++;
        }

        public void Remove(T item)
        {

        }
    

        public int Count()
        {
            int count = 0;
            T[] tempArray = new T[arrayCapacity];

            for (int i = 0; i < arraySize; i++)
            {
                tempArray[i] = arrayList[i];
                count++;
            }
            return count;
        }

        public override string ToString()
        {
            string arrayString = "";

            for (int i = 0; i < arraySize; i++)
            {
                arrayString = arrayString + arrayList[i];
            }

            return arrayString;
        }

        //public static MyList operator +(MyList l1, MyList l2)
        //{
        //    return new MyList(l1.listOne + l2.listOne, l1.listTwo + l2.listTwo);
        //}
    }
}
