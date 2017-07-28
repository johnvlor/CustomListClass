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
                if (index >= arrayList.Length)
                    return default(T);
                else
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
            int indexCount = 0;

            T[] tempArray = new T[arrayCapacity];

            for (int i = 0; i < arraySize; i++)
            {
                if (arrayList[indexCount].Equals(item) == false)
                {
                    tempArray[i] = arrayList[indexCount];
                }
                else
                {
                    i--;
                    arraySize--;
                }
                indexCount++;
            }
            arrayList = tempArray;
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
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
            for (int i = 0; i < list2.arraySize; i++)
            {
                list1.Remove(list2[i]);
            }

            return list1;
        }

        public MyList<T> Zip(MyList<T> list2)
        {
            int indexCount = 0;
            int remainingIndex = 0;

            MyList<T> zipList = new MyList<T>();

            if (arraySize <= list2.arraySize)
            {
                indexCount = arraySize;
            }
            else
            {
                indexCount = list2.arraySize;
            }

            for (int i = 0; i < indexCount; i++)
            {
                zipList.Add(arrayList[i]);
                zipList.Add(list2[i]);
                remainingIndex++;
            }

            if (arraySize == list2.arraySize)
            {
                return zipList;
            }
            else if (arraySize < list2.arraySize)
            {
                indexCount = list2.arraySize - indexCount;
                for (int i = 0; i < indexCount; i++)
                {
                    zipList.Add(list2[remainingIndex]);
                    remainingIndex++;
                }
            }
            else
            {
                indexCount = arraySize - indexCount;
                for (int i = 0; i < indexCount; i++)
                {
                    zipList.Add(arrayList[remainingIndex]);
                    remainingIndex++;
                }
            }

            return zipList;
        }

        public void Sort()
        {
            T[] tempArray = new T[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                if (i == 0)
                {
                    tempArray[i] = arrayList[i];
                }
                else
                {
                    for (int j = 0; j < tempArray.Length; j++)
                    {
                        if (Compare<T>(arrayList[i], tempArray[j]) < 0)
                        {
                            SwapFunction<T>(ref arrayList[i], ref tempArray[j]);
                        }
                        else
                        {
                            tempArray[i] = arrayList[i];
                        }
                    }
                }
            }
            arrayList = tempArray;
        }

        public void SwapFunction<T>(ref T item1, ref T item2)
        {
            T temporaryValue;
            temporaryValue = item1;
            item1 = item2;
            item2 = temporaryValue;
        }

        public static int Compare<T>(T item1, T item2)
        {
            return Comparer<T>.Default.Compare(item1, item2);
        }
    }
}
