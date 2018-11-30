using EInvoice.Data.Data;
using System.Web;
using System.Web.Mvc;

namespace Data.Utilities
{
    public class PermissionLogin : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            base.OnActionExecuting(actionContext);
            var userSession = (Customer)HttpContext.Current.Session[Constant.UserSession];
            if (userSession == null)
            {
                actionContext.HttpContext.Response.Redirect("~/Login/Login");
            }
        }
    }
}