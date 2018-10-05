using System;
using EInvoice.Service;
using System.Web.Mvc;
using EInvoice.Data.Data;

namespace EInvoice.Web.Controllers.InvoiceController
{
	public class InvoiceController : Controller
	{
		private IInvoiceService _invoiceService { get; set; }

		public InvoiceController(IInvoiceService invoiceService)
		{
			_invoiceService = invoiceService;
		}

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult NewInvocie()
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