using System;

namespace SearchingAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] searchSequence = { 2, 4, 5, 7,9,11,3,0,33,5 };
            //Linear Search
            LinearSearch.LinearSearch.LinearSearchTest(searchSequence,9); //Index of input in sequence : 4 

            //Binary Search
            //Iterative Implementation
            BinarySearch.BinarySearch.BinarySearchIterativeTest(searchSequence, 9);//Index of input in sorted sequence : 7
            //Recursive Implementation
            //BinarySearch.BinarySearch.BinarySearchIterativeTest(searchSequence, 9,0,searchSequence.Length);//Index of input in sorted sequence : 7

            //Jump Search
            JumpSearch.JumpSearch.JumpSearchTest(searchSequence, 9);


        }
    }
}
