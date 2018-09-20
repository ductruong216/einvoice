using EInvoice.Service;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICustomerService _customerService;

		public HomeController(ICustomerService customerService)
		{
			_customerService = customerService;
		}

		public ActionResult Index()
		{
			// DXCOMMENT: Pass a data model for GridView
			var model = _customerService.GetAll();
			return View(model);
		}

		public ActionResult GridViewPartialView()
		{
			// DXCOMMENT: Pass a data model for GridView in the PartialView method's second parameter
			var model = _customerService.GetAll();
			return PartialView("GridViewPartialView", model);
		}
	}
}

public enum HeaderViewRenderMode { Full, Title }