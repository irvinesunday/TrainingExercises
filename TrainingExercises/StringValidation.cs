using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExercises
{
    public class StringValidation
    {
        /// <summary>
        /// Time: Worst Case --> O(N) Best Case --> O(N)
        /// Space: O(N)
        /// </summary>
        /// <param name="stringToValidate"></param>
        /// <param name="openBracketCharacter"></param>
        /// <param name="closedBracketCharacter"></param>
        /// <returns></returns>
        public static bool IsStringValid(string stringToValidate, 
                                         char openBracketCharacter, char closedBracketCharacter)
        {
            if (String.IsNullOrEmpty(stringToValidate))
                throw new ArgumentNullException(stringToValidate, "Input value cannot be empty.");

            char firstBracketFound = '\0';
            int bracketsCounter = 0;

            for(int i = 0; i < stringToValidate.Length; i++)
            {                
                if (stringToValidate[i] == openBracketCharacter)
                {
                    if(firstBracketFound == '\0')
                        firstBracketFound = openBracketCharacter;

                    bracketsCounter += 1;
                }
                else if(stringToValidate[i] == closedBracketCharacter)
                {
                    if (firstBracketFound == '\0')
                        return false; // First bracket in string must be an open bracket

                    bracketsCounter -= 1;
                }
            }

            if (bracketsCounter == 0)
                return true;

            return false;
        }
    }
}
