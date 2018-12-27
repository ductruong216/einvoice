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
	    public ActionResult Cancel()
	    {
	        var model = Mapper.Map<List<InvoiceViewModel>>(_invoiceService.GetAllCancel());

	        return View("_Cancel", model);
	    }

	    [HttpPost]
	    public ActionResult CancelIssuedInvoice(int invoiceId)
	    {
	        try
	        {
	            _invoiceService.CancelIssuedInvoice(invoiceId);
	            return Success("Cancel Successfully");
	        }
	        catch (Exception e)
	        {
	            return Error("Delete Failed");
	        }
	    }
    }
}