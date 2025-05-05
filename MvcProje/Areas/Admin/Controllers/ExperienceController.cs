using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperienceController : Controller
    {
        private readonly DataBaseUserContext db;

        public ExperienceController(DataBaseUserContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var experiences = db.Experiences.ToList();
            return View(experiences);
        }
    }
}
