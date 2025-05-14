using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO.About;
using MvcProje.Areas.Admin.Filter;
using DataAccessLayer.Context; // kendi context’inin namespace’i

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [CheckSession]
    public class AdminController : Controller
    {
        private readonly DataBaseUserContext _context; // kendi context’inin adı neyse onu yaz

        public AdminController(DataBaseUserContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AboutEdit(int id)
        {
            var about = _context.AboutDb.FirstOrDefault(x => x.Id == id);
            if (about == null)
                return NotFound();

            var dto = new AboutUpdateDto
            {
                Id = about.Id,
                Name = about.Name,
                Surname = about.Surname,
                Address = about.Address,
                Phone = about.Phone,
                Mail = about.Mail,
                Description = about.Description,
                Image = about.Image
            };

            return View(dto);
        }

        [HttpPost]
        public IActionResult AboutEdit(AboutUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            var about = _context.AboutDb.FirstOrDefault(x => x.Id == dto.Id);
            if (about == null)
                return NotFound();

            about.Name = dto.Name;
            about.Surname = dto.Surname;
            about.Address = dto.Address;
            about.Phone = dto.Phone;
            about.Mail = dto.Mail;
            about.Description = dto.Description;
            about.Image = dto.Image;

            _context.AboutDb.Update(about);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
