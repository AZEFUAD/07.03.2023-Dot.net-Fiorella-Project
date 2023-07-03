using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
