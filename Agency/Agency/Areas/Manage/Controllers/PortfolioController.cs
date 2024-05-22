using Agency.DAL;
using Agency.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agency.Areas.Manage.Controllers
{
        [Area("Manage")]
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.Portfolio.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Portfolio portfolio)
        {
            return View();
        }
    }
}
