using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //var recurse = new Recursion();
            //recurse.StringReverse2(new char[] { 's', 'u', 'n', 'd', 'a', 'y' });         

            //string word = ""; // "today is (Tuesday), tomorrow will be (Sunday))";
            //bool result = StringValidation.IsStringValid(word, '(', ')');

            //Console.WriteLine(result);
            //Console.Read();

            var swapValues = new SwapValues();

            int firstNumber = 123;
            int secondNumber = 456;
            swapValues.SwapNumbersWithoutTempVariable(firstNumber, secondNumber);

            //string firstString = "Irvine is a cool guy";
            //string secondString = "Sunday is an Engineer";
            //swapValues.SwapStringsWithoutTempVariable(firstString, secondString);
        }
    }
}
