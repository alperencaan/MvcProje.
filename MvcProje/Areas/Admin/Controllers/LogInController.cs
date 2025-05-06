using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Context;
using ModelLayer.DTO;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LogInController : Controller
    {
        private readonly DataBaseUserContext _context;

        public LogInController(DataBaseUserContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LogInDTO logInDTO)
        {
            if (ModelState.IsValid)
            {
                var adminUser = await _context.AdminDb
                    .FirstOrDefaultAsync(u => u.UserName == logInDTO.Username && u.Password == logInDTO.Password);

                if (adminUser != null)
                {
                    return RedirectToAction("Index", "Authentication", new { area = "" });
                }
                else
                {
                    // Hatalı giriş
                    ModelState.AddModelError(string.Empty, "Geçersiz kullanıcı adı veya şifre.");
                }
            }

            return View(logInDTO);
        }
    }
}
