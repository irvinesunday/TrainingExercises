using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExercises
{
    class SwapValues
    {
        public void SwapNumbersWithoutTempVariable(int firstNumber, int secondnumber)
        {
            firstNumber = Int32.Parse((firstNumber.ToString() + secondnumber.ToString()));
            secondnumber = Int32.Parse(firstNumber.ToString().Remove(firstNumber.ToString().IndexOf(secondnumber.ToString()[0]))); // Remove the value after the secondNumber
            firstNumber = Int32.Parse(firstNumber.ToString().Substring(firstNumber.ToString().IndexOf(secondnumber.ToString()[0]) + secondnumber.ToString().Count())); // Remove everything before the secondNumber

            Console.WriteLine(firstNumber.ToString());
            Console.WriteLine(secondnumber.ToString());
            Console.Read();

        }
        public void SwapStringsWithoutTempVariable(string firstString, string secondString)
        {
            firstString = firstString + "%" + secondString;
            secondString = firstString.Remove(firstString.IndexOf('%'));
            firstString = firstString.Substring(firstString.IndexOf('%') + 1);

            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
            Console.Read();
        }
    }
}
