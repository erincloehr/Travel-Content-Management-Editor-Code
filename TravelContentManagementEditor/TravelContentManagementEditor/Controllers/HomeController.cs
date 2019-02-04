using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TravelContentManagementEditor.Models;

namespace TravelContentManagementEditor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tours()
        {
            ViewData["Message"] = "Tours";

            return View();
        }

        public IActionResult Events()
        {
            ViewData["Message"] = "Events";

            return View();
        }

        public IActionResult Places()
        {
            ViewData["Message"] = "Places";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
