using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Model.ViewModels;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly DataBaseUserContext _db;

        public AdminController(DataBaseUserContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var viewModel = new AuthenticationViewModel
            {
                Educations = _db.EducationDb.ToList(),
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEducation(EducationDb education)
        {
            if (education != null)
            {
                _db.EducationDb.Add(education);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEducation(int id)
        {
            var education = _db.EducationDb.Find(id);
            if (education != null)
            {
                _db.EducationDb.Remove(education);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditEducation(int id)
        {
            var education = _db.EducationDb.Find(id);
            return View(education);
        }

        [HttpPost]
        public IActionResult EditEducation(EducationDb education)
        {
            if (education != null)
            {
                _db.EducationDb.Update(education);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}