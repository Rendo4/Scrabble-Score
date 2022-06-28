using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrabbleScore
{
  public class Word
  {
    public string Input { get; set; }
    public static List<char> WordList = new List<char>(0);
    

    public Word(string input)
    {
      Input = input;
    }

    public char Split(string input)
    {
      WordList = input.ToCharArray().ToList();
      return WordList[0];
    }
  }
}