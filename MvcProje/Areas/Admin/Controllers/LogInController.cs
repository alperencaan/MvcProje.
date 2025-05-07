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

        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Login sayfasını göster
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] LogInDTO logInDTO)
        {
            return RedirectToAction("Index", "Authentication", new { area = "Admin" }); // bunu sonra sil

            if (ModelState.IsValid)
            {
                var adminUser = await _context.AdminDb
                    .FirstOrDefaultAsync(u => u.UserName == logInDTO.Username && u.Password == logInDTO.Password);

                if (adminUser != null)
                {
                    // Başarılı giriş – AuthenticationController'a yönlendirme
                    return RedirectToAction("Index", "Authentication", new { area = "Admin" });
                }

                ModelState.AddModelError(string.Empty, "Geçersiz kullanıcı adı veya şifre.");
            }

            return View(logInDTO); // Form hatalıysa tekrar göster
        }
    }
}
