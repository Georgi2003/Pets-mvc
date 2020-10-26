using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcProj.Models;
using DataLibraly;
using static DataLibraly.BisnessLogic.AnimalProcessor;
using DataLibraly.BisnessLogic;
using DataLibraly.Models;

namespace mvcProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*var data = LoadAnimal();

            List<AnimalModel> animal = new List<AnimalModel>();

            foreach (var row in data)
            {
                animal.Add(new AnimalModel
                {
                    id = row.id,
                    last_name = row.last_name,
                    message = row.message
                });
            }*/

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cats()
        {
            return View();
        }

        public IActionResult Dogs()
        {
            return View();
        }

        public ActionResult Announcement()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Announcement(AnimalModel model)
        {
            if (ModelState.IsValid) 
            {
                int recordsCreated = CreateAnimal(model.id,
                    model.first_name,
                    model.last_name,
                    model.message); 
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
