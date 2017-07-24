using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class MyList<T> : IEnumerator<T>
    {
        T[] arrayList;
        int arraySize;
        int arrayCapacity;

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        //indexer
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

        public void Add(T item)
        {
            if (arraySize == arrayCapacity)
            {
               if (arrayCapacity == 0)
                {
                    arrayCapacity = 4;
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

        public void Remove()
        {

        }

        public int Count()
        {
            int count = 0;
            //if (arraySize == arrayCapacity)
            //{
            //    if (arrayCapacity == 0)
            //    {
            //        arrayCapacity = 4;
            //    }
            //    else
            //    {
            //        arrayCapacity = arrayCapacity * 2;
            //    }

            //    T[] tempArray = new T[arrayCapacity];

            //    for (int i = 0; i < arraySize; i++)
            //    {
            //        tempArray[i] = arrayList[i];
            //        count++;
            //    }
            //    arrayList = tempArray;
            //}
            T[] tempArray = new T[arrayCapacity];

            for (int i = 0; i < arraySize; i++)
            {
                tempArray[i] = arrayList[i];
                count++;
            }
            return count;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
