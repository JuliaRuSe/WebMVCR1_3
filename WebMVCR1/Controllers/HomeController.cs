using Microsoft.AspNetCore.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View();
        }
        //public string Index()
        //{
        //    int hour = DateTime.Now.Hour;
        //    string Greeting = hour < 12 ? "Доброе " : "Добрый день";
        //    return Greeting;
        //}
        // с параметром
        public string Hel(string hel)
        {
            int hour = DateTime.Now.Hour;

            string Greeting = hour < 12 ? "Доброе утро" + ", " + hel : "Добрый день" + ", " + hel;
            return Greeting;
        }

        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            return View("Hello", p);
        }
    }
}
