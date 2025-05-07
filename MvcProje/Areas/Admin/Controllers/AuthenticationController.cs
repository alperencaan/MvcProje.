using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Model.Entity;
using Model.ViewModels;

namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthenticationController : Controller
    {
        private readonly DataBaseUserContext db;

        public AuthenticationController(DataBaseUserContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new AuthenticationViewModel
            {
                Abouts = db.AboutDb.ToList(),
                Experiences = db.ExperienceDb.ToList()
                //educatıon
            };

            return View(viewModel);
        }


    }

}
