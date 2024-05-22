using Microsoft.AspNetCore.Mvc;

namespace Agency.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create() { 
            return View();
        }
    }
}
