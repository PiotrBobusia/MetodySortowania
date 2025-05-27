
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using MetodySortowania.Interfaces;
using MetodySortowania.SortTypes;

test(new InsertionSort());
test(new SelectionSort());
test(new BubbleSort());
test(new ShellSort());
test(new MergeSort());
test(new QuickSort());
test(new HeapSort());


void test (ISort SortingMethod)
{
    var array = new int[] { 4, 5, 1, 0, 65, 3, -4, 9, 5, -8, 5, 0 , 7, 8, 9, 11, 12, 14 };
    SortingMethod.Sort<int>(array);

    foreach (var item in array)
    {
        Console.Write(item + " ");
    }

    Console.WriteLine();
};