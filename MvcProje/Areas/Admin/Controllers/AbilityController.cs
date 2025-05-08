using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace MvcProje.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class AbilityController : Controller
    {
        private readonly DataBaseUserContext db;

        public AbilityController(DataBaseUserContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var abilities = db.Abilities.ToList();

            return View(abilities);
        }
    }
}
