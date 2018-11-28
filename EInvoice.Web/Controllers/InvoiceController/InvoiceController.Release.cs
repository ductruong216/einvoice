using AutoMapper;
using EInvoice.Data.Data;
using EInvoice.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers.InvoiceController
{
	public partial class InvoiceController : Controller
	{
		public ActionResult Release()
		{
			var model = Mapper.Map<List<InvoiceViewModel>>(_invoiceService.GetAll()
				.Where(x => x.isDel == false && x.Status == "Released").OrderByDescending(x => x.ReleaseDate));
	
			return View("_Release", model);
		}

		[HttpPost]
		public ActionResult EditRelease(Invoice invoice)
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
		public ActionResult DeleteRelease(int id)
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
	}
}