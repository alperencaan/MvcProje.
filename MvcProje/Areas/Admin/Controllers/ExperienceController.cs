using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;

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
            var experiences = db.ExperienceDb.ToList(); // 'ExperienceDb' veri setinden veriyi alıyoruz
            return View(experiences); // 'experiences' değişkenini View'a gönderiyoruz
        }

    }
}
