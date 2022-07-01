using Microsoft.AspNetCore.Mvc;

namespace LoginTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
