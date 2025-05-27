using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodySortowania.Interfaces;

namespace MetodySortowania.SortTypes
{
    public class QuickSort : ISort
    {
        public T[] Sort<T>(T[] myArray) where T : IComparable<T>
        {
            return PartialSort(myArray, 0, myArray.Length - 1);
        }

        private T[] PartialSort<T>(T[] myArray, int startIndex, int endIndex) where T : IComparable<T>
        {
            if (startIndex >= endIndex) return myArray;

            int pivotIndex = endIndex;

            int lowIndexer = startIndex;

            for (int i = lowIndexer; i < pivotIndex; i++)
            {
                if (myArray[i].CompareTo(myArray[pivotIndex]) < 0)
                {
                    (myArray[i], myArray[lowIndexer]) = (myArray[lowIndexer], myArray[i]);
                    lowIndexer++;
                }
            }

            (myArray[pivotIndex], myArray[lowIndexer]) = (myArray[lowIndexer], myArray[pivotIndex]);

            PartialSort(myArray, 0, lowIndexer - 1);
            PartialSort(myArray, lowIndexer + 1, endIndex);

            return myArray;
        }

    }
}
