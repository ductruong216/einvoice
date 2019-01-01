using System.Collections.Generic;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers.InvoiceController
{
    public partial class InvoiceController : Controller
    {
        public ActionResult Report()
        {
            // Load ra mot cai list gom cac truong do
            return View();
        }

        [HttpPost]
        public JsonResult ReportOnUse(int quarter, int year)
        {
            IList<Data.DTO.Report> listReport;

            if (quarter == 5 && year == 2018)
            {
                listReport = _invoiceService.ReportOnUseInvoices(4, year);
                return Json(listReport, JsonRequestBehavior.AllowGet);
            }
            else if (quarter == 5 && year == 2019)
            {
                listReport = _invoiceService.ReportOnUseInvoices(1, year);
                return Json(listReport, JsonRequestBehavior.AllowGet);
            }
            else
            {
                listReport = _invoiceService.ReportOnUseInvoices(quarter, year);
                return Json(listReport, JsonRequestBehavior.AllowGet);
            }
        }
    }
}