using Microsoft.AspNetCore.Mvc;

namespace empty_test.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
