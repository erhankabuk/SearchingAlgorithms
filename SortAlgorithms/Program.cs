using System;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] searchSequence = { 2, 4, 5, 7, 9, 11, 3, 0, 33, 5 };

            //Selection Sort
            SelectionSort.SelectionSort.SelectionSortTest(searchSequence);//Sorted sequence : 0,2,3,4,5,5,7,9,11,33

        }
    }
}
