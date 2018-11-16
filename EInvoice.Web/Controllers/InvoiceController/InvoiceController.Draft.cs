using System;
using AutoMapper;
using EInvoice.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Implementation;
using EInvoice.Data.Services;

namespace EInvoice.Web.Controllers.InvoiceController
{
	public partial class InvoiceController : Controller
	{

		public ActionResult DraftInvoice()
		{
			return View();
		}

		public ActionResult _DraftInvoice()
		{
			var model = Mapper.Map<List<InvoiceViewModel>>(_invoiceService.GetAll());
			return PartialView("_DraftInvoice", model);
		}

		public IEnumerable<Pattern> GetPattern()
		{
			return _patternService.GetAll();
		}


		[HttpGet]
		public ActionResult Edit(int id)
		{
			var invoice = Mapper.Map<InvoiceViewModel>(_invoiceService.GetSingleById(id));
			return View(invoice);
		}

		[HttpPost]
		public void Edit(Invoice invoice)
		{
			try
			{
				_invoiceService.Update(invoice);
			
			}
			catch (Exception e)
			{
				ViewData["EditError"] = e.Message;
			}
		}
	}
}