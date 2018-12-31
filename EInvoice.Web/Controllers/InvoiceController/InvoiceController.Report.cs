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
            var listReport = _invoiceService.ReportOnUseInvoices(quarter, year);
            return Json(listReport, JsonRequestBehavior.AllowGet);
        }
    }
}