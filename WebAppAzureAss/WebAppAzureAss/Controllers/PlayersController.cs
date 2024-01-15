using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using WebAppAzureAss.Models;

namespace WebAppAzureAss.Controllers
{
    public class PlayersController : Controller
    {
        private static List<Players> players = new List<Players>
    {
        new Players { PId = 1, PName = "Kane Williamson", PCountry = "New Zealand", PType = "Batsman" },
        new Players { PId = 2, PName = "Jadeja", PCountry = "India", PType = "All-Rounder" },
        new Players { PId = 3,PName="Ben Stokes",PCountry="England",PType="All-Rounder"}

    };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Players());
        }
        [HttpPost]
        [HttpPost]
        public IActionResult Create(Players pla)
        {
            if (ModelState.IsValid)
            {
                players.Add(pla);
            }
            return View();
        }

    }
}