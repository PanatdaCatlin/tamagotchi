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
      TamagotchiVariable.ClearAll();
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
      if (myTamagotchiVariable.CheckHealth())
      {
        return View("Status", myTamagotchiVariable);
      }else{
        return RedirectToAction("Death");
      }

    }
    [HttpGet("/giveHealth")]
    public ActionResult AddHealth()
    {
      TamagotchiVariable myTamagotchiVariable = TamagotchiVariable.Find(1);
      myTamagotchiVariable.PlusHealth();
      return View("Status", myTamagotchiVariable);
    }
    [Route("/death")]
    public ActionResult Death()
    {
      TamagotchiVariable myTamagotchiVariable = TamagotchiVariable.Find(1);
      return View("Death", myTamagotchiVariable);

    }
  }
}
