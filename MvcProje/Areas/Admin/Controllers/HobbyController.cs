using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HobbyController : Controller
    {
        private readonly DataBaseUserContext db;

        public HobbyController(DataBaseUserContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var Hobbies = db.Hobbies.ToList();

            return View(Hobbies);
        }
    }
}
