using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using ScrabbleScore;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void isLetterconvertingToValue()
    {
      Word testWord = new Word("C");
      int test = testWord.Split(testWord.Input);
      Assert.AreEqual(3, test);
    }

    [TestMethod]
    public void isLetterValuesBeingAddedTogether()
    {
      Word testWord = new Word("CAR");
      int test = testWord.Split(testWord.Input);
      Assert.AreEqual(test, 5);
    }
  }
}