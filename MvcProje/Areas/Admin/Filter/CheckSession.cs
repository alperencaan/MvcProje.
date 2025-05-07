using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcProje.Areas.Admin.Filter
{
    public class CheckSession: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var session = context.HttpContext.Session.GetString("AdminUsername");
            if (session == null)
            {
                context.Result = new RedirectToActionResult("Index", "Login", new { area = "Admin" });
            }
            base.OnActionExecuting(context);
        }
    }
    }

