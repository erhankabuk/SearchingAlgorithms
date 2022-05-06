using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms.BinarySearch
{
    public class BinarySearch
    {
        //Iterative Implementation
        public static int BinarySearchAlgorithm(int[] sequence, int input)
        {
            int leftIndex = 0, rightIndex = sequence.Length - 1;

            while (leftIndex <= rightIndex)
            {
                int middle = leftIndex + (rightIndex - leftIndex) / 2;
                if (sequence[middle] == input)
                {
                    return middle;
                }
                else if (sequence[middle] > input) rightIndex = middle - 1;
                else if (sequence[middle] < input) leftIndex = middle + 1;
            }

            return -1;
        }
        /*

        //Recursive Implementation
        public static int BinarySearchAlgorithm(int[] sequence, int input, int leftIndex, int rightIndex)
        {
            if (rightIndex >= leftIndex)
            {
                int middle = leftIndex + (rightIndex - leftIndex) / 2;
                if (sequence[middle] == input) return middle;
                else if (sequence[middle] > input) return BinarySearchAlgorithm(sequence, input, leftIndex, middle - 1);
                else if (sequence[middle] < input) return BinarySearchAlgorithm(sequence, input, middle + 1, rightIndex);
            }
            return -1;
        }
        */


        public static void BinarySearchIterativeTest(int[] sequence, int input)
        {
            //Sort array
            Array.Sort(sequence);

            int result = BinarySearchAlgorithm(sequence, input);

            if (result != -1) Console.WriteLine("Index of input in sorted sequence : " + result);
            else Console.WriteLine("Sorted sequence doesn't have {0}", input);
        }
    }
}
