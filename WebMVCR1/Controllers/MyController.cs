using Microsoft.AspNetCore.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        public string Index(string hel)
        {
            //int hour = DateTime.Now.Hour;

            //string Greeting = hour < 12 ? "Доброе утро" + ", " + hel : "Добрый день" + ", " + hel;
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;
        }
    }
}
