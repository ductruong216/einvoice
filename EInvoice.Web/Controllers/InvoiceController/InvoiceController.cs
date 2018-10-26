using EInvoice.Data.Data;
using EInvoice.Data.Services;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers.InvoiceController
{
	public  class InvoiceController : Controller
	{
		private readonly IInvoiceService _invoiceService;
		private readonly IPaymentMethodService _paymentMethodService;

		public InvoiceController(IInvoiceService invoiceService, IPaymentMethodService paymentMethodService)
		{
			_invoiceService = invoiceService;
			_paymentMethodService = paymentMethodService;
		}

		public ActionResult Index()
		{
			return View();
		}

		public IList<PaymentMethod> GetPayments()
		{
			return _paymentMethodService.GetAll();
		}

		public ActionResult NewInvoice()
		{

			return View();
		}

		[HttpPost]
		public void AddNewInvoice(Invoice invoice)
		{
			try
			{
				_invoiceService.Add(invoice);
			}
			catch (Exception e)
			{
				ViewData["EditError"] = e.Message;
			}
		}
	}
}