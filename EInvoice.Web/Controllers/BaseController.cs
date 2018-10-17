using EInvoice.Service;
using System.Web.Mvc;
using EInvoice.Data.Services;

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