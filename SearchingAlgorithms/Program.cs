using System;

namespace SearchingAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] SearchSequence = { 2, 4, 5, 7,9,11,3,0,33,5 };
            //Linear Search
            LinearSearch.LinearSearch.LinearSearchTest(SearchSequence,1); //Index of input in sequence : 4 

            //Binary Search
            BinarySearch.BinarySearch.BinarySearchIterativeTest(SearchSequence, 1);//Index of input in sorted sequence : 7
        }
    }
}
