using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExercises
{
    class SwapValues
    {
        /// <summary>
        /// Function to swap two numbers without a temp variable
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondnumber"></param>
        public void SwapNumbersWithoutTempVariable(int firstNumber, int secondnumber)
        {
            Console.WriteLine("--- BEFORE SWAP ---");
            Console.WriteLine($"First number: {firstNumber.ToString()}");
            Console.WriteLine($"Second number: {secondnumber.ToString()}\n");          

            firstNumber = Int32.Parse((firstNumber.ToString() + secondnumber.ToString()));
            secondnumber = Int32.Parse(firstNumber.ToString().Remove(firstNumber.ToString().IndexOf(secondnumber.ToString()[0]))); // Remove the value after the secondNumber
            firstNumber = Int32.Parse(firstNumber.ToString().Substring(firstNumber.ToString().IndexOf(secondnumber.ToString()[0]) + secondnumber.ToString().Count())); // Remove everything before the secondNumber

            Console.WriteLine("--- AFTER SWAP ---");
            Console.WriteLine("First number: " + firstNumber.ToString());
            Console.WriteLine("Second number: " + secondnumber.ToString());
            Console.Read();

        }

        /// <summary>
        /// Function to swap two strings without a temp variable
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        public void SwapStringsWithoutTempVariable(string firstString, string secondString)
        {
            Console.WriteLine("--- BEFORE SWAP ---");
            Console.WriteLine($"First string: {firstString}");
            Console.WriteLine($"Second string: {secondString}\n");
            
            firstString = firstString + "%" + secondString; // Use a wild card to concatenate the strings
           
            // Use the selected wild card to get the two substrings
            secondString = firstString.Remove(firstString.IndexOf('%'));
            firstString = firstString.Substring(firstString.IndexOf('%') + 1);

            Console.WriteLine("--- AFTER SWAP ---");
            Console.WriteLine($"First string: {firstString}");
            Console.WriteLine($"Second string: {secondString}");
            Console.Read();
        }
    }
}
