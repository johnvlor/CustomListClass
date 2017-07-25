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
            arrayList = new T[] { };
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

        public int Count()
        {
            int count = 0;

            for (int i = 0; i < arraySize; i++)
            {
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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static MyList<T> operator +(MyList<T> l1, MyList<T> l2)
        {
            MyList<T> myList = new MyList<T>();

            myList = l1 + l2;

            return myList;
        }
    }
}
