using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class MyList<T> : IEnumerable<T>
    {
        T[] arrayList;
        int arraySize;
        int arrayCapacity;
        private int count;

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
            count = 0;
            arraySize = 0;
            arrayCapacity = 0;
            arrayList = new T[arraySize];
            arrayList = new T[] { };
        }

        public int Count
        {
            get
            {
                count = 0;
                for (int i = 0; i < arraySize; i++)
                {
                    count++;
                }
                return count;
            }
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
            int count = 0;

            T[] tempArray = new T[arrayCapacity];

            for (int i = 0; i < arraySize; i++)
            {
                if (AreEqual<T>(item, arrayList[count]) == false)
                {
                    tempArray[i] = arrayList[count];
                }
                else
                {
                    i--;
                    arraySize--;
                }
                count++;
            }
            arrayList = tempArray;
        }

        public static bool AreEqual<T>(T item1, T item2)
        {
            return EqualityComparer<T>.Default.Equals(item1, item2);
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < arraySize; i++)
            {
                yield return arrayList[i];
            }

            //throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
            //throw new NotImplementedException();
        }

        //public static MyList<T> operator +(MyList<T> l1, MyList<T> l2)
        //{
        //    MyList<T> myList = new MyList<T>();

        //    string list1 = l1.ToString();
        //    string list2 = l2.ToString();
        //    //string result = list1 + list2;

        //    return (list1, list2);
        //}
    }
}
