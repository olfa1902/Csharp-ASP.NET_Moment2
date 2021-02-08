using Microsoft.AspNetCore.Mvc;
using Moment2_statisk_till_mvc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moment2_statisk_till_mvc.Controllers
{
    public class Webdevelopment : Controller
    {
        [Route("/webbutveckling")]
        public IActionResult Index()
        {
            var JsonStr = System.IO.File.ReadAllText("courses.json");
            var JsonObj = JsonConvert.DeserializeObject<IEnumerable<Courses>>(JsonStr);

            return View(JsonObj);
        }
    }
}
