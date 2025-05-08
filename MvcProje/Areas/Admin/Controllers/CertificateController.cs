using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CertificateController : Controller
    {
        private readonly DataBaseUserContext db;

        public CertificateController(DataBaseUserContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // DbSet üzerinden veritabanından tüm sertifikaları al
            var certificates = db.CertificateDb.ToList();  // ToList() ile DbSet'ten liste elde ediyorsunuz.

            // Veriyi View'a gönder
            return View(certificates);
        }
    }
}
