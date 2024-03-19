using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Controllers
{
    public class HomeController : Controller
    {
        // by default this will be called if you look at the program.cs
        // right click and generate view from here only careful about the naming too
        // chnage return type to IActionResult if you want to return csHTML as the response
        public IActionResult Index()
        {
            // you can specify the view name
            return View();
        }
    }
}
