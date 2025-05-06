using DataAccessLayer.Context;  // DbContext'i kullanmak için gerekli
using Microsoft.AspNetCore.Mvc;  // MVC Controller için gerekli
using Microsoft.EntityFrameworkCore;  // Veritabanı işlemleri için gerekli
using ModelLayer.DTO;  // DTO kullanabilmek için gerekli

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]  // Admin alanındaki route'lar için
    public class LogInController : Controller
    {
        private readonly DataBaseUserContext _context;

        // Constructor'da DbContext'i alıyoruz
        public LogInController(DataBaseUserContext context)
        {
            _context = context;
        }

        // GET: /Admin/LogIn
        public IActionResult Index()
        {
            return View();  // Views/Admin/LogIn/LogIn.cshtml dosyasını döndürüyoruz
        }

        // POST: /Admin/LogIn
        [HttpPost]  // Form post işlemi
        public async Task<IActionResult> Index(LogInDTO logInDTO)
        {
            if (ModelState.IsValid)  // Model doğrulaması
            {
                // Veritabanındaki kullanıcıyı kontrol ediyoruz
                var adminUser = await _context.AdminDb
                    .FirstOrDefaultAsync(u => u.UserName == logInDTO.Username && u.Password == logInDTO.Password);

                if (adminUser != null)
                {
                    // Kullanıcı doğrulandı, admin paneline yönlendir
                    return RedirectToAction("Dashboard", "Home", new { area = "Admin" });
                }
                else
                {
                    // Hatalı giriş, kullanıcıyı bilgilendir
                    ModelState.AddModelError(string.Empty, "Geçersiz kullanıcı adı veya şifre.");
                }
            }

            // Model geçerli değilse, tekrar giriş sayfasını göster
            return View(logInDTO);
        }
    }
}
