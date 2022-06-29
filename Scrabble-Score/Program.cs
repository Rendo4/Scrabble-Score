using System;
using System.Collections.Generic;
using ScrabbleScore;
using System.Linq;

public class Program
{
  public static Dictionary<string, int> letterValues = new Dictionary<string, int>() {
    {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4}, {"five", 5}, {"eight", 8}, {"ten", 10} 
  };
  
  public static void Main()
  {
    

    Console.WriteLine("Enter a word to check its scrabble value");
    string userInput = Console.ReadLine();
    Word newWord = new Word(userInput);
    char test = newWord.Split(newWord.Input);
    Console.WriteLine(test);
  }
}