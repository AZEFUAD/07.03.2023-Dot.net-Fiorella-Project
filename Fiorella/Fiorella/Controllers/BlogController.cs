﻿using Microsoft.AspNetCore.Mvc;

namespace Fiorella.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
