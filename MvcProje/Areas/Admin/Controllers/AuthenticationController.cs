using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using MvcProje.Models; // ← DataBaseUserEntities’in tanımlı olduğu namespace (kendi projenize göre düzenleyin)
using System.Linq;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthenticationController : Controller
    {
        DataBaseUserContext db = new DataBaseUserContext();

        public IActionResult Index()
        {
            var aboutValues = db.About.ToList(); // ← About tablosundan verileri çeker
            return View(aboutValues); // View'a verileri gönder
        }
    }
}
