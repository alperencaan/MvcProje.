using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller 
    {
        private readonly DataBaseUserContext db;

        public ContactController(DataBaseUserContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var contacts = db.ContactDb.ToList(); 
            return View(contacts); 
        }
    }
}
