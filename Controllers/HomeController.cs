using DeckofDecks.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeckofDecks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DeckDAL api = new DeckDAL();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DrawCard d = api.NewDeck();
            return View(d);
        }           

        public IActionResult DisplayDraw(int c)
        { 
            DrawCard nd = api.NewDeck();
            string id = nd.deck_id;
            nd = api.DrawPatrol(id, c);
            return View(nd);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}