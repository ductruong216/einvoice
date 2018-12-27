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
	    public ActionResult Report()
	    {
	        return View();
	    }
	}
}