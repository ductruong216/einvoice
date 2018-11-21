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

		public ActionResult Draft()
		{
			var model = Mapper.Map<List<InvoiceViewModel>>(_invoiceService.GetAll()
				.Where(x => x.isDel == false && x.Status == "Draft").OrderByDescending(x => x.ID));
			return View("_Draft", model);
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
		public ActionResult Edit(Invoice invoice)
		{
			try
			{
				_invoiceService.UpdateInvoice(invoice);
				return Success("Edit Successfully");
			}
			catch (Exception e)
			{
				return Error("Edit Failed");
			}
		}

		[HttpPost]
		public ActionResult Delete(int id)
		{
			try
			{
				_invoiceService.DeleteInvoice(id);

				return Success("Delete Successfully");
			}
			catch (Exception e)
			{
				return Error("Delete Failed");
			}
		}

		[HttpPost]
		public ActionResult ReleaseInvoice(int id)
		{
			try
			{
				_invoiceService.ChangeStatus(id);

				return Success("Release successfully");
			}
			catch (Exception e)
			{
				return Error(e.Message);
			}
		}
	}
}