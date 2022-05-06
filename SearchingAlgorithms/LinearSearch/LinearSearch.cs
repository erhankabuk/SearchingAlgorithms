using System;

namespace SearchingAlgorithms.LinearSearch
{
    public class LinearSearch
    {
        public static int LinearSearchAlgorithm(int[] sequence, int input)
        {
            int index = -1;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == input)
                {
                    index = i;
                }
            }
            return index;
        }
        public static void LinearSearchTest(int[] sequence, int input)
        {
            int result = LinearSearchAlgorithm(sequence, input);
            if (result != -1) Console.WriteLine("Index of input in sequence : " + result);
            else Console.WriteLine("Sequence doesn't have {0}", input);
        }

    }
}
