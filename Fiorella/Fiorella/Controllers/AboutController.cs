using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
