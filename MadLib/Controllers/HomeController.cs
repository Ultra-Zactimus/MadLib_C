using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/create")]
    public ActionResult Create() {return View(); }

    [Route("/madlibs")]
    public ActionResult MadLibs (string noun1, string noun2, string verb1, string verb2)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Noun1 = noun1;
      myMadLibVariable.Noun2 = noun2;
      myMadLibVariable.Verb1 = verb1;
      myMadLibVariable.Verb2 = verb2;
      return View(myMadLibVariable);
    }
    
  }
}