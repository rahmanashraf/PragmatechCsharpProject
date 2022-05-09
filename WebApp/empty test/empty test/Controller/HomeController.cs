using Microsoft.AspNetCore.Mvc;

namespace empty_test.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
