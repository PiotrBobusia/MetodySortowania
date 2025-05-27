using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodySortowania.Interfaces;

namespace MetodySortowania.SortTypes
{
    public class ShellSort : ISort
    {
        public T[] Sort<T>(T[] myArray) where T : IComparable<T>
        {

            for(int h = myArray.Length/2; h > 0; h /= 2)
            {
                for(int x = h; x < myArray.Length; x++)
                {
                    
                    int actualIndex = x;
                    T buffer = myArray[actualIndex];

                    while (actualIndex - h >= 0)
                    {
                        if (buffer.CompareTo(myArray[actualIndex - h]) < 0)
                        {
                            myArray[actualIndex] = myArray[actualIndex - h];
                            actualIndex -= h;
                        }
                        else break;
                    }

                    myArray[actualIndex] = buffer;
                }
            }
            return myArray;
        }

    }
}
