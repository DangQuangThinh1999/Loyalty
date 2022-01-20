using Microsoft.AspNetCore.Mvc;

namespace Loyalty.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}