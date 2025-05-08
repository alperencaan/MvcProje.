using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EducationController : Controller
    {
        private readonly DataBaseUserContext db;

        public EducationController(DataBaseUserContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Get all education records
            var educations = db.EducationDb.ToList();

            // Pass the data to the view
            return View(educations);
        }
    }
}
