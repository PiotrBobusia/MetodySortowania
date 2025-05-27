using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodySortowania.Interfaces;

namespace MetodySortowania.SortTypes
{
    public class MergeSort : ISort
    {

        public T[] Sort<T>(T[] myArray) where T : IComparable<T>
        {
            if (myArray.Length <= 1) return myArray;

            T[] LeftArray = GetSubArray<T>(myArray, 0, myArray.Length / 2 - 1);
            T[] RightArray = GetSubArray<T>(myArray, myArray.Length / 2, myArray.Length - 1);

            Sort(LeftArray);
            Sort(RightArray);

            int x = 0, y = 0, k = 0;
            while(x < LeftArray.Length && y < RightArray.Length)
            {
                if (LeftArray[x].CompareTo(RightArray[y]) < 0) myArray[k++] = LeftArray[x++];
                else myArray[k++] = RightArray[y++];
            }

            while(x < LeftArray.Length) myArray[k++] = LeftArray[x++];
            while (y < RightArray.Length) myArray[k++] = RightArray[y++];

            return myArray;
        }

        private T[] GetSubArray<T>(T[] myArray, int startIndex, int endIndex)
        {
            int length = endIndex + 1 - startIndex;
            T[] resultArray = new T[length];
            Array.Copy(myArray, startIndex, resultArray, 0, length);

            return resultArray;
        }
    }
}
