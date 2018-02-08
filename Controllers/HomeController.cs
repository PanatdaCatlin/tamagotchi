using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class HomeController : Controller
  {
    [Route("/home")]
    public ActionResult Home()
    {
      return View();
    }
    [Route("/status")]
    public ActionResult Status()
    {
      TamagotchiVariable myTamagotchiVariable = new TamagotchiVariable();
      myTamagotchiVariable.SetName(Request.Query["tamagotchi-name"]);
      myTamagotchiVariable.Save();
      return View("Status", myTamagotchiVariable);
    }
    [HttpGet("/takeHealth")]
    public ActionResult MinusHealth()
    {
      TamagotchiVariable myTamagotchiVariable = TamagotchiVariable.Find(1);
      myTamagotchiVariable.TakeHealth();
      return View("Status", myTamagotchiVariable);
    }
    [Route("/food")]
    public ActionResult Food()
    {
      return View();
    }
    [Route("/play")]
    public ActionResult Play()
    {
      return View();
    }
    [Route("/sleep")]
    public ActionResult Sleep()
    {
      return View();
    }
    [Route("/death")]
    public ActionResult Death()
    {
      return View();
    }


  }
}
