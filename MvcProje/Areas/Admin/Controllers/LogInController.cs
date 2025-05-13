using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Context;
using ModelLayer.DTO;
using System.Text.Json;

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
            return View(); // Login sayfasi
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] LogInDTO logInDTO)
        {


            if (ModelState.IsValid)
            {
                var adminUser = await _context.AdminDb
                    .FirstOrDefaultAsync(u => u.UserName == logInDTO.Username && u.Password == logInDTO.Password);

                if (adminUser != null)
                {
                    HttpContext.Session.SetString("AdminUsername", JsonSerializer.Serialize(adminUser));
                    return RedirectToAction("Index", "Admin", new { area = "Admin" });
                }

                ModelState.AddModelError(string.Empty, "Geçersiz kullanıcı adı veya şifre.");
            }

            return View(logInDTO); 
        }
    }
}
