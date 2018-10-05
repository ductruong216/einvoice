using System;
using System.Web.Mvc;
using EInvoice.Service;

namespace EInvoice.Web.Controllers.CategoryController
{
	public partial class CategoryController : Controller
	{
		private readonly IUnitService _unitService;
		private readonly IProductService _productService;
		private readonly ICustomerService _customerService;
	
		public CategoryController(IUnitService unitService, IProductService productService, ICustomerService customerService)
		{
			_unitService = unitService;
			_productService = productService;
			_customerService = customerService;
		}
		// GET: Category
		public ActionResult Index()
		{
			return View();
		}
		public void SafeExecute(Action method)
		{
			try
			{
				method();
			}
			catch (Exception e)
			{
				ViewData["EditError"] = e.Message;
			}
		}
	}
}