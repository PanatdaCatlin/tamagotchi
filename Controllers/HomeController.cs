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
