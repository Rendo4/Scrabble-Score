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
    public void isWordSplitApart()
    {
      Word testWord = new Word("car");
      List<char> SplitWord = new List<char>(0);
      SplitWord.Add('c');
      char test = testWord.Split(testWord.Input);
      Assert.AreEqual(SplitWord[0], test);
    }

    [TestMethod]
    public void isLetterAValue()
    {
      Word testWord = new Word("car");
      List<char> SplitWord = new List<char>(0);
      SplitWord.Add('c');
      Assert.AreEqual(SplitWord.LetterToValue(), 3);
    }
  }
}