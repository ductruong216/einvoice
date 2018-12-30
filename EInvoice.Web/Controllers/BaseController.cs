using EInvoice.Data.Services;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers
{
    public class BaseController : Controller
    {
        private IUnitService _unitSerivce;

        public BaseController(IUnitService unitSerivce)
        {
            _unitSerivce = unitSerivce;
        }

        public void GetAllUnit()
        {
            _unitSerivce.GetAll();
        }
    }
}