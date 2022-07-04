using Microsoft.AspNetCore.Mvc;

namespace LoginTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data=ViewBag.Data;
            return View();
        }
    }
}
