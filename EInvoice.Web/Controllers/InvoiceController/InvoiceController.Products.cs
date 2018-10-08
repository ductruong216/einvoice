using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using EInvoice.Data.Data;
using EInvoice.Web.Models;

namespace EInvoice.Web.Controllers.InvoiceController
{
	public partial class InvoiceController : Controller
	{

		public ActionResult ProductTable()
		{
			return View();
		}

		[ValidateInput(false)]
		public ActionResult ProductTablePartial(Invoice invoice)
		{
			var model = Mapper.Map<List<ProductViewModel>>(_productService.GetByInvoiceID(invoice.ID));

			return PartialView("ProductTable", model);
		}

		[ValidateInput(false)]
		public ActionResult UpdateInvoice(Invoice invoice)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_invoiceService.Update(invoice);
					_invoiceService.Save();
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			else


				ViewData["EditError"] = "Please, correct all errors.";

			return ProductTablePartial(invoice);
		}
	}
}
