using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using MvcProje.Models; 


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

            return PartialView();
        }
    }
}
