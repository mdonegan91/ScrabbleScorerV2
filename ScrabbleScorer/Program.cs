using System;
using System.Collections.Generic;
using ScrabbleScorer.Models;

namespace ScrabbleScorer
{
  class Program
  {
    static void Main()
    { // making static function in game makes not unique. doesnt change per instance. always what it does not matter what it is. only thing it takes into account is input.
      Console.WriteLine("Enter a word to calculate your Scrabble score:");
      string word1 = Console.ReadLine();
      int score = ScrabbleScore.WordScore(word1);
      Console.WriteLine($"Your Scrabble score for '{word1}' is {score}");
    }
  }
}