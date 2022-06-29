using System;
using System.Collections.Generic;
using ScrabbleScore;
using System.Linq;

public class Program
{ 
  public static void Main()
  {
    Console.WriteLine("Enter a word to check its scrabble value");
    string userInput = Console.ReadLine().ToUpper();
    Word newWord = new Word(userInput);
    newWord.Split(newWord.Input);
    Console.WriteLine(newWord.Score);
  }
}