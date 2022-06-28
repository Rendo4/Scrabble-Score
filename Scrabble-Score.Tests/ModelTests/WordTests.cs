using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble-Score;

namespace Scrabble-Score.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void isWordSplitApart()
    {
      Word testWord = new Word("Car");
      List<string> SplitWord = new List<string>("c","a","r");
      Assert.AreEqual(SplitWord, testWord.split());
    }
  }
}