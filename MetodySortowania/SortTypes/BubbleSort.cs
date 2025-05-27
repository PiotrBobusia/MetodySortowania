using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodySortowania.Interfaces;

namespace MetodySortowania.SortTypes
{
    public class BubbleSort : ISort
    {

        public T[] Sort<T>(T[] myArray) where T : IComparable
        {
            for(int i = 0; i < myArray.Length-1; i++)
            {
                for(int j = 0; j < myArray.Length-1; j++)
                {
                    if (myArray[j].CompareTo(myArray[j + 1]) > 0) 
                        (myArray[j], myArray[j + 1]) = (myArray[j+1], myArray[j]);
                }
            }

            return myArray;
        }

    }
}
