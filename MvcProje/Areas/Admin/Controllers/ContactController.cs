using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller // Sınıf ismi "ContactController" olmalı
    {
        private readonly DataBaseUserContext db;

        public ContactController(DataBaseUserContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var contacts = db.ContactDb.ToList(); // DbSet isminin doğru olduğundan emin olun: "Contacts"
            return View(contacts); // Direkt olarak listeyi View'a gönderiyoruz
        }
    }
}
