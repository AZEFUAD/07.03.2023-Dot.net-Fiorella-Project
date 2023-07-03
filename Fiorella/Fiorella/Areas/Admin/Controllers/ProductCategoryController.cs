using Fiorella.Areas.Admin.ViewModels.ProductCategory;
using Fiorella.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductCategoryController : Controller
    {
        private readonly AppDbContext _context;
        public ProductCategoryController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ProductCategoryIndexVM());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductCategoryCreateVM model)
        {
            if (!ModelState.IsValid) return View();

            var productCategory = new ProductCategory
            {
                Name = model.Name,
                CreatedDate = DateTime.Now
            };

            _context.ProductCategories.Add(productCategory);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
