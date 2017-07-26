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

        public MyList()
        {
            count = 0;
            arraySize = 0;
            arrayCapacity = 0;
            arrayList = new T[arraySize];
            arrayList = new T[] { };
        }

        public void Add(T item)
        {
            if (arraySize == arrayCapacity)
            {
                CheckArrayCapacity();

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

        public int CheckArrayCapacity()
        {
            if (arrayCapacity == 0)
            {
                arrayCapacity = 2;
            }
            else
            {
                arrayCapacity = arrayCapacity * 2;
            }

            return arrayCapacity;

        }

        public void Remove(T item)
        {
            int count = 0;

            T[] tempArray = new T[arrayCapacity];

            for (int i = 0; i < arraySize; i++)
            {
                if (Equal<T>(item, arrayList[count]) == false)
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

        public static bool Equal<T>(T item1, T item2)
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

        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> oneList = new MyList<T>();

            for (int i = 0; i < list1.arraySize; i++)
            {
                oneList.Add(list1[i]);
            }

            for (int i = 0; i < list2.arraySize; i++)
            {
                oneList.Add(list2[i]);
            }

            return oneList;
        }

        public static MyList<T> operator -(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> oneList = new MyList<T>();

            for (int i = 0; i < list1.arraySize; i++)
            {
                for (int j = 0; j < list2.arraySize; j++)
                {
                    list1.Remove(list2[j]);
                }
            }

            return list1;
        }
    }
}
