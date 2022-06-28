using System;
using System.Collections.Generic;
using ScrabbleScore;
using System.Linq;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a word to check its scarbble value");
    string userInput = Console.ReadLine();
    Word newWord = new Word(userInput);
    char test = newWord.Split(newWord.Input);
    Console.WriteLine(test);

  }
}