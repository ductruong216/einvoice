using System.Web;

namespace EInvoice.Data.Utilities
{
    public class SessionHelper
    {
        public static object GetSessionValue(string sessionName)
        {
            return HttpContext.Current.Session[sessionName];
        }
    }
}
