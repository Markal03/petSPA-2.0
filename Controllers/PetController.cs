using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PetSPA.Controllers
{
    public class PetController : Controller
    {
        // 
        // GET: /Pet/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}