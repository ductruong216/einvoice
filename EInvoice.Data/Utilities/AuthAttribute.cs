using Data.Utilities;
using Data.Utilities.Enumeration;
using EInvoice.Data.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EInvoice.Data.Utilities
{
    public class AuthAttribute : ActionFilterAttribute
    {
         private Enumerations.Role[] Roles { get; set; }

        public AuthAttribute(params Enumerations.Role[] roles)
        {
            Roles = roles;
        }

        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            var userSession = (User)HttpContext.Current.Session[Constant.UserSession];

            if (userSession == null)
            {
                actionContext.Result = new RedirectResult("~/Login/Login");
            }
            else
            {
                string[] roles = new string[Roles.Length];
                for (int i = 0; i < Roles.Length; i++)
                {
                    roles[i] = Roles[i].ToString();
                }

                if (!roles.Contains(userSession.Position))
                {
                    actionContext.Result = new RedirectResult("~/Login/Login");
                }
            }
            base.OnActionExecuting(actionContext);
        }
    }
}
