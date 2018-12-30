using EInvoice.Data.Data;
using System.Web;
using System.Web.Mvc;

namespace EInvoice.Data.Utilities
{
    public class PermissionLogin : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            base.OnActionExecuting(actionContext);
            var userSession = (User)HttpContext.Current.Session[Constant.UserSession];
            if (userSession == null)
            {
                actionContext.HttpContext.Response.Redirect("~/Login/Login");
            }
        }
    }
}