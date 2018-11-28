﻿using System;
using AutoMapper;
using EInvoice.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DevExpress.XtraCharts;
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
				_invoiceService.Release(id);

				return Success("Release successfully");
			}
			catch (Exception e)
			{
				return Error(e.Message);
			}
		}
		[HttpPost]
		public ActionResult ShowDraft(int id)
		{
			try
			{
				_invoiceService.Release(id);

				return Success("Release successfully");
			}
			catch (Exception e)
			{
				return Error(e.Message);
			}
		}

		public ActionResult ShowInvoice(int? invoiceId){
			var report = new InvoiceReport();
			report.Parameters["IDParameter"].Value = invoiceId;
			report.Parameters["IDParameter"].Visible = false;
			return View(report);
		}

		public ActionResult ExportDocumentViewer()
		{
			return DevExpress.Web.Mvc.DocumentViewerExtension.ExportTo(
				new InvoiceReport());
		}
	}
}