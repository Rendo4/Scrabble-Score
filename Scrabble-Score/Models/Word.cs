using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrabbleScore
{
  public class Word
  {
    public string Input { get; set; }
    public static char[] letters; 
    public int Score {get; set;}
    

    public Word(string input)
    {
      Input = input;
    }

    public int Split(string input)
    {
      Score = 0;
      char[] letters = input.ToCharArray();
      foreach (char letter in letters)
      { 
        if ("AEIOULNRST".Contains(letter)) 
        {
          Score += 1;
        } 
        else if ("DG".Contains(letter))
        {
          Score += 2;
        }
        else if ("BCMP".Contains(letter))
        {
          Score += 3;
        }
        else if ("FHVWY".Contains(letter))
        {
          Score += 4;
        }
        else if ('K' == letter)
        {
          Score += 5;
        }
        else if ("JX".Contains(letter))
        {
          Score += 8;
        }
        else 
        {
          Score += 10;
        }
      }
      return Score;
    }

    public char[] GetLetters()
    {
      return letters;
    }
  }
}