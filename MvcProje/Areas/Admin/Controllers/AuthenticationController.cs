using Microsoft.AspNetCore.Mvc;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")] 
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
