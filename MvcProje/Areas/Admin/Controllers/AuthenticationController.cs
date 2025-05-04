using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;


namespace MvcProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthenticationController : Controller
    {
        DataBaseUserContext db = new DataBaseUserContext();

        public IActionResult Index()
        {
            var Value = db.AboutDb.ToList(); 
          
            return View(Value); 
        }
        public PartialViewResult Experience()
        {
            var experience = db.ExperienceDb.ToList(); 
            return PartialView("~/Areas/Admin/Views/Authentication/_Experience.cshtml", experience); 
        }




    }
}
