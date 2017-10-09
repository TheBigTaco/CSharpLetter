using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public ActionResult Hello()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Adam");
      myLetterVariable.SetVacation("Thailand");
      myLetterVariable.SetSouvenir("Coconut Bikini");
      myLetterVariable.SetSender("Snuffles");
      return View(myLetterVariable);
    }
    [Route("/favorite_photos")]
    public ActionResult FavoritePhotos()
    {
      return View();
    }
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/greeting_card")]
    public ActionResult GreetingCard()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient(Request.Query["recipient"]);
      myLetterVariable.SetSender(Request.Query["sender"]);

      return View("Hello", myLetterVariable);
    }

    [Route("/madlibs")]
    public ActionResult Madlibs()
    {
      return View();
    }

    [Route("/story_time")]
    public ActionResult StoryTime()
    {
      Madlibs myMadLibs = new Madlibs();
      myMadLibs.SetName(Request.Query["name"]);
      myMadLibs.SetAnimal(Request.Query["animal"]);
      myMadLibs.SetFood(Request.Query["food"]);
      myMadLibs.SetAdjective(Request.Query["adjective"]);
      myMadLibs.SetVerb(Request.Query["verb"]);
      myMadLibs.SetNoun(Request.Query["noun"]);

      return View(myMadLibs);
    }
  }
}
