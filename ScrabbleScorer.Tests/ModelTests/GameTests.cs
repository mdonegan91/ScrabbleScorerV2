using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class GameTests
  {

    
    [TestMethod]
    public void CalculatesScrabbleScore_ReturnsScoreForSingleLetter_Int()
    {
      string input = "a";
      ScrabbleScore firstScore = new ScrabbleScore(letter);
      int result = NewFunction(input);
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void NameOfMethodWeAreTesting2_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // we can also use the arrange, act, assert organization in any test. 
      //CollectionAssert.AreEqual(ExpectedResult, CodeToTest);
    }
  }
}
