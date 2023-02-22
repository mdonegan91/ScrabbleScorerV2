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
      int result = ScrabbleScore.LetterScore(input);
      Assert.AreEqual(1, result);
    } //code that passes switch case -- test was re

    [TestMethod]
    public void WordScore_ReturnsScoreForEntireWord_Int()
    {
      string input = "hi";
      int result = ScrabbleScore.WordScore(input);
      Assert.AreEqual(5,result);
    } //testing return of score for string. test that runs through switch case every instance of letter appearing in word and adds them
  }
}
