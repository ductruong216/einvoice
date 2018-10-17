using EInvoice.Data.Data;
using EInvoice.Data.Services;
using System;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers.InvoiceController
{
	public partial class InvoiceController : Controller
	{
		private IInvoiceService _invoiceService { get; set; }
		private IProductService _productService { get; set; }

		public InvoiceController(IInvoiceService invoiceService, IProductService productService)
		{
			_invoiceService = invoiceService;
			_productService = productService;
		}

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult NewInvoice()
		{
			return View();
		}

		public void AddNewInvoice(Invoice invoice)
		{
			try
			{
				_invoiceService.Add(invoice);
				_invoiceService.Save();
			}
			catch (Exception e)
			{
				ViewData["EditError"] = e.Message;
			}
		}
	}
}