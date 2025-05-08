using Microsoft.AspNetCore.Mvc;

namespace MvcProje.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
