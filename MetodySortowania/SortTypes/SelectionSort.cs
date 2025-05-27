using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodySortowania.Interfaces;

namespace MetodySortowania.SortTypes
{
    public class SelectionSort : ISort
    {
        public T[] Sort<T>(T[] myArray) where T : IComparable
        {

            for (int border = 0; border < myArray.Length - 1; border++)
            {
                T minValue = myArray[border];
                int minIndex = border;

                for (int j = border; j < myArray.Length; j++)
                {
                    if (myArray[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = myArray[minIndex];
                    }
                }

                (myArray[border], myArray[minIndex]) = (myArray[minIndex], myArray[border]);

            }
            return myArray;
        }
    }
}
