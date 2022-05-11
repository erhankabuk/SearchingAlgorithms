using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms.JumpSearch
{
    public class JumpSearch
    {
        public static int JumpSearchAlgorithm(int[] sequence, int input)
        {
            //Sort array
            Array.Sort(sequence);
          
            int length = sequence.Length;
            int jump = (int)Math.Floor(Math.Sqrt(length));
            int previous = sequence[0];

            //Find the block where input can be present
            while (sequence[Math.Min(jump, length) - 1] < input)
            {
                previous = jump;
                jump += jump;
                if (previous >= length) return -1;
            }

            //Than do linear search in present block
            while (sequence[previous] < input)
            {
                previous++;

                //If input doesn't exist in array or loop reached next block
                if (previous == Math.Min(jump, input)) return -1;
            }

            //If input is in block
            if (sequence[previous] == input) return previous;

            return -1;
        }
        public static void JumpSearchTest(int[] sequence, int input)
        {

            int result = JumpSearchAlgorithm(sequence, input);

            if (result != -1) Console.WriteLine("Index of input in sorted sequence : " + result);
            else Console.WriteLine("Sorted sequence doesn't have {0}", input);

        }
    }
}
