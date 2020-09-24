using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine(@"
      
      SCRABBLE WORD SCORE FINDER
      
      ---------------------
      
      Enter your word:  ");

      string inputWord = Console.ReadLine();
      Letter newLetter = new Letter();
      Console.WriteLine("Your score is: " + newLetter.LetterScore(inputWord));
    }
  }
}
