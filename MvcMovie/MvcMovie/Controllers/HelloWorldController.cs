using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web; // ez plusz

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name="Isti", int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        public IActionResult PageNotFoundCustom()
        {
            return View();
        }

        
    }

    
}
