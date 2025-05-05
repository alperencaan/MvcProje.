using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthenticationController : Controller
    {
        private readonly DataBaseUserContext db;

        public AuthenticationController(DataBaseUserContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var value = db.AboutDb.ToList();
            return View(value);
        }

        public PartialViewResult Experience()
        {
            var experienceList = db.Experiences.ToList();
            return PartialView("_Experience", experienceList);
        }

    }
}
