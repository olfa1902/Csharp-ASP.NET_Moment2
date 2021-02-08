using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moment2_statisk_till_mvc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moment2_statisk_till_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Filmlista()
        {
            // Lista med ViewData
            List<Movies> filmlista = new List<Movies>
            {
                new Movies {Titel = "Goodfellas", Kategori = "Crime", Speltid = 148},
                new Movies {Titel = "Terminator 2", Kategori = "Science Fiction", Speltid = 137},
                new Movies {Titel = "A few good men", Kategori = "Drama", Speltid = 138},
                new Movies {Titel = "Die Hard", Kategori = "Thriller", Speltid = 131},
            };

            ViewData["filmer_i_lista"] = filmlista;

            // Lista med ViewBag
            List<Movies> filmlista2 = new List<Movies>
            {
                new Movies("Goodfellas", "Crime", 148),
                new Movies("Terminator 2", "Science Fiction", 137),
                new Movies("A few good men", "Drama", 138),
                new Movies("Die Hard", "Thriller", 131),
            };

            ViewBag.filmer = filmlista2;

            List<Movies> filmlista3 = new List<Movies>
            {
                new Movies("Goodfellas", "Crime", 148),
                new Movies("Terminator 2", "Science Fiction", 137),
                new Movies("A few good men", "Drama", 138),
                new Movies("Die Hard", "Thriller", 131),
            };

            ViewModel vm = new ViewModel
            {
                FilmDetaljLista = filmlista3
            };

            string sessiontext = "Detta är en textrad som förflyttas genom Session, vid tryck på filmlista och sedan filmlista - session";
            HttpContext.Session.SetString("sessionstext", sessiontext);

            return View(vm);
        }

        public IActionResult Filmlistasession()
        {
            string sessionsutskrift = HttpContext.Session.GetString("sessionstext");
            ViewBag.text = sessionsutskrift;

            return View();
        }
    }
}
