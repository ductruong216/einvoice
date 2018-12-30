using EInvoice.Common;
using EInvoice.Data.Data;
using System.Collections.Generic;
using System.Linq;
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

        public void GetReport(int quater, int year)
        {
            var listReport = new List<Report>();
            var totalRegister = 1000;
            var listPattern = _patternService.GetAll();
            if (quater == 1 && year == 2018)
            {
                var listInvoice = _invoiceService.GetAll()
                .Where(x => x.ReleaseDate.Value.Month == quater
                            && x.ReleaseDate.Value.Year == year
                            && x.Status != InvoiceStatus.Draft.ToString());

                var pattern1 = listPattern[0];
                var listSerial = new List<Serial>(pattern1.Serials);
                var serial1 = listSerial[0].Name;

                var Report1 = new Report()
                {
                    Pattern = listPattern[0].Name,
                    Serial = serial1,
                    StartNoInventroryNo = null,
                    ToInventroryNo = null,
                    FromBuyNo = 1,
                    ToBuyNo = totalRegister,
                    // tong so da su dung, phat hanh, xoa, bo, mat
                    TotalInvoiceIssued = listInvoice.Count(),
                    // Tu so da su dung, phat hanh, xoa bo, mat
                    FromInvoiceIssuedNo = listInvoice.Min(x => x.No),
                    ToInvoiceIssuedNo = listInvoice.Max(x => x.No),

                    // tong so da su dung
                    TotalUsed = listInvoice.Where(x => x.Status == InvoiceStatus.Issued.ToString())
                       .Count(),

                    TotalDelete = listInvoice.Where(x => x.Status == InvoiceStatus.Cancel.ToString()).Count(),
                    //NoDelete = // liet ke ra tat ca cac so hoa don 
                };
                listReport.Add(Report1); // => by qua json => load ra view
            }
        }
    }
}