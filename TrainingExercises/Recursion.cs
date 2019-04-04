using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExercises
{
    public class Recursion
    {
        /// <summary>
        /// Print a string in reverse order.
        /// </summary>
        /// <param name="input"></param>
        public void StringReverse(char[] input)
        {
            DoStringReverse(input, 0);
            Console.Read();
        }

        private void DoStringReverse(char[] input, int index)
        {
            if (input.Length == 0 || index >= input.Length)
                return;

            DoStringReverse(input, index + 1);

                Console.Write(input[index]);
        }

        public void StringReverse2(char[] input)
        {
            DoStringReverse2(0, input.Length - 1, input);
            Console.Read();
        }

        /// <summary>
        /// Write a function that reverses a string
        /// Do not allocate extra space for another array, 
        /// you must do this by modifying the input array in-place with O(1) extra memory.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="input"></param>
        private void DoStringReverse2(int start, int end, char[] input)
        {
            if (start >= end)
            {
                foreach(var item in input)                
                  Console.Write(item);                                 
                return;
            }

            char temp = input[start];
            input[start] = input[end];
            input[end] = temp;

            DoStringReverse2(start + 1, end - 1, input);
        }
    }
}
