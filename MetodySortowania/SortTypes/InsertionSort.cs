using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodySortowania.Interfaces;

namespace MetodySortowania.SortTypes
{
    public class InsertionSort : ISort
    {
        public T[] Sort<T>(T[] myArray) where T : IComparable<T>
        {
            int border = 1;

            for (; border < myArray.Length; border++)
            {
                T buffer = myArray[border];
                int indexer = border - 1;

                for (indexer = border - 1; indexer >= 0; indexer--)
                {
                    if (buffer.CompareTo(myArray[indexer]) < 0)
                    {
                        myArray[indexer + 1] = myArray[indexer];
                    }
                    else
                    {
                        break;
                    }
                }

                myArray[indexer + 1] = buffer;

            }
            return myArray;
        }
    }
}
