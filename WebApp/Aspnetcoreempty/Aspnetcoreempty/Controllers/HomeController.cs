using Microsoft.AspNetCore.Mvc;

namespace Aspnetcoreempty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
