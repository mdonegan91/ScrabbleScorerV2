using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class GameTests
  {

    
    [TestMethod]
    public void LetterScore_ReturnsScoreForSingleLetter_Int()
    {
      char input = 'a';
      ScrabbleScore firstScore = new ScrabbleScore();
      int result = firstScore.LetterScore(input);
      Assert.AreEqual(1, result);
    } //code that passes switch case

    [TestMethod]
    public void WordScore_ReturnsScoreForEntireWord_Int()
    {
      string input = "hi";
      ScrabbleScore firstWord = new ScrabbleScore();
      int result = firstWord.WordScore(input);
      Assert.AreEqual(5,result);
    } //testing return of score for string. test that runs through switch case every instance of letter appearing in word and adds them
  }
}
