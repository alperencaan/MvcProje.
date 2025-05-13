using Microsoft.AspNetCore.Mvc;
using MvcProje.Areas.Admin.Filter;

namespace MvcProje.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]
        [CheckSession]
        public IActionResult Index()
        {
            return View();
        }
    }
}
