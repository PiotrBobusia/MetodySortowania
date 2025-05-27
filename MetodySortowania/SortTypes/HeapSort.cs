using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MetodySortowania.Interfaces;

namespace MetodySortowania.SortTypes
{
    public class HeapSort : ISort
    {
        public T[] Sort<T>(T[] myArray) where T : IComparable<T>
        {
            for(int x = myArray.Length/2; x >= 0; x--)
            {
                Heapify<T>(myArray, myArray.Length, x);
            }


            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                (myArray[0], myArray[i]) = (myArray[i], myArray[0]);
                Heapify<T>(myArray, i, 0);
            }

            return myArray;
        }

        private void Heapify<T>(T[] array, int size, int index) where T : IComparable<T>
        {
            int maxIndex = index;
            int leftChild = index * 2 + 1;
            int rightChild = index * 2 + 2;

            maxIndex = leftChild < size && array[leftChild].CompareTo(array[maxIndex]) > 0 ? leftChild : maxIndex;

            maxIndex = rightChild < size && array[rightChild].CompareTo(array[maxIndex]) > 0 ? rightChild : maxIndex;

            if(index != maxIndex)
            {
                (array[index], array[maxIndex]) = (array[maxIndex], array[index]);
                Heapify(array, size, maxIndex);
            }
        }
    }
}
