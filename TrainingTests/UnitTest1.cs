using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingExercises;

namespace TrainingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringWithBothOpenAndClosedBracketsInOrder()
        {
            string sentence = "(if (taken? x) median (1 x))";

            bool result = StringValidation.IsStringValid(sentence, '(', ')');

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void StringWithOneClosedBracketMissingOpenBracket()
        {
            string sentence = "The )quick) brown fox jumped over the (blue) wall.";

            bool result = StringValidation.IsStringValid(sentence, '(', ')');

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void StringWithOneOpenBracketMissingClosedBracket()
        {
            string sentence = "The (quick) brown fox jumped over the (blue wall.";

            bool result = StringValidation.IsStringValid(sentence, '(', ')');

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void StringStartingWithClosedBracket()
        {
            string sentence = ") The quick brown ().";

            bool result = StringValidation.IsStringValid(sentence, '(', ')');

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void StringWithOneClosedBracket()
        {
            string sentence = ":-)";

            bool result = StringValidation.IsStringValid(sentence, '(', ')');

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void StringWithOneOpenBracket()
        {
            string sentence = "(-:";

            bool result = StringValidation.IsStringValid(sentence, '(', ')');

            Assert.IsFalse(result);
        }
    }
}
