using System;

namespace SortAlgorithms.SelectionSort
{
    public class SelectionSort
    {
        public static  int[] SelectionSortAlgorithm(int[] sequence)
        {
            int length = sequence.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int subIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (sequence[j] < sequence[subIndex]) subIndex = j;

                    //Swap Algorithm
                    int temp = sequence[subIndex];
                    sequence[subIndex] = sequence[i];
                    sequence[i] = temp;

                }

            }
            return sequence;
        }

        public static void SelectionSortTest(int[] sequence)
        {
            int[] sortedList = SelectionSortAlgorithm(sequence);
            Console.WriteLine("Sorted sequence : {0}",string.Join(",", sortedList));

        }

    }
}
