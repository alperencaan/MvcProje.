﻿using Microsoft.AspNetCore.Mvc;

namespace MvcProje.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
