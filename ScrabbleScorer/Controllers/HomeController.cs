using Microsoft.AspNetCore.Mvc;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/output")]
    public ActionResult Output(string currentword)
    {
      ScrabbleScore myScrabbleScore = new ScrabbleScore();
      myScrabbleScore.CurrentWord = currentword;
      myScrabbleScore.score = ScrabbleScore.WordScore(myScrabbleScore.CurrentWord);
      return View(myScrabbleScore);
    }
  }
}