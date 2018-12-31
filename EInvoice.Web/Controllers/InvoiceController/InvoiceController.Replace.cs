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
        public ActionResult GetReplace()
        {
            var model = Mapper.Map<List<InvoiceViewModel>>(_invoiceService.GetAllReplace());

            return View("_Replace", model);
        }

        [HttpPost]
        public ActionResult ReplaceIssuedInvoice(int invoiceId)
        {
            try
            {
                _invoiceService.ReplaceIssuedInvoice(invoiceId);
                return Success("Cancel Successfully");
            }
            catch (Exception e)
            {
                return Error("Delete Failed");
            }
        }

        [HttpGet]
        public ActionResult Replace(int id)
        {
            var invoice = _invoiceService.GetSingleById(id);
            var invoiceViewModel = Mapper.Map<InvoiceViewModel>(invoice);
            invoiceViewModel.No = _invoiceService.GetInvoiceNumber(invoice);
            invoiceViewModel.ReplaceFor = invoice.No;
            return View(invoiceViewModel);
        }

        [HttpPost]
        public ActionResult Replace(Invoice invoice)
        {
            try
            {
                _invoiceService.UpdateInvoice(invoice);
                return Success("Replace Successfully");
            }
            catch (Exception e)
            {
                return Error("Edit Failed");
            }
        }


        [HttpPost]
        public JsonResult NewReplace(Invoice invoice)
        {
            try
            {
                _invoiceService.NewReplace(invoice);
                return Success("Replace Successfully!");
            }
            catch (Exception e)
            {
                return Error(e.Message);
            }
        }
    }
}