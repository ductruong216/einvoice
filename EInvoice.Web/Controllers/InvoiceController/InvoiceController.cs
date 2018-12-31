using EInvoice.Data.Data;
using EInvoice.Data.Services;
using EInvoice.Data.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers.InvoiceController
{
    [PermissionLogin]
    public partial class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;
        private readonly IPaymentMethodService _paymentMethodService;
        private readonly IPatternService _patternService;

        public InvoiceController(IInvoiceService invoiceService,
                                 IPaymentMethodService paymentMethodService,
                                 IPatternService patternService
                                )
        {
            _invoiceService = invoiceService;
            _paymentMethodService = paymentMethodService;
            _patternService = patternService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(Invoice invoice, bool isRelease)
        {
            try
            {
                if (isRelease)
                {
                    _invoiceService.SaveAndIssue(invoice);
                    return Success("Issue Successfully!");
                }
                _invoiceService.AddDraft(invoice);
                return Success("Successfully!");
            }
            catch (Exception e)
            {
                return Error(e.Message);
            }
        }

        #region JSON STATUS

        public JsonResult Success(string message)
        {
            return Json(new { Success = true, Message = message }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Error(string message)
        {
            return Json(new { Success = false, Message = message }, JsonRequestBehavior.AllowGet);
        }

        #endregion JSON STATUS

        #region Get component

        public IList<PaymentMethod> GetPayments()
        {
            return _paymentMethodService.GetAll();
        }

        public JsonResult GetAllPattern()
        {
            var patterns = _patternService.GetAll().ToList();
            var listPattern = new List<SelectListItem>();
            foreach (var item in patterns)
            {
                var pattern = new SelectListItem
                {
                    Text = item.Name,
                    Value = item.ID.ToString()
                };
                listPattern.Add(pattern);
            }
            return Json(listPattern, JsonRequestBehavior.AllowGet);
        }

        public List<SelectListItem> GetSeries(int patternId)
        {
            var serials = _invoiceService.GetSeriesByPattern(patternId).ToList();
            var listSerial = new List<SelectListItem>();
            foreach (var item in serials)
            {
                var serial = new SelectListItem
                {
                    Text = item.Name,
                    Value = item.ID.ToString()
                };
                listSerial.Add(serial);
            }

            return listSerial;
        }

        public JsonResult GetSerial(int patternId)
        {
            return Json(GetSeries(patternId), JsonRequestBehavior.AllowGet);
        }

        public IEnumerable<Serial> GetAllSerial()
        {
            return _invoiceService.GetSeries();
        }

        public IEnumerable<Pattern> GetPattern()
        {
            return _patternService.GetAll();
        }

        public List<SelectListItem> GetPaymentType()
        {
            var payments = _paymentMethodService.GetAll().ToList();
            var listPayment = new List<SelectListItem>();
            foreach (var item in payments)
            {
                var payment = new SelectListItem
                {
                    Text = item.Name,
                    Value = item.ID.ToString()
                };
                listPayment.Add(payment);
            }

            return listPayment;
        }

        #endregion Get component

        public ActionResult ShowDraft(int? invoiceId)
        {
            var report = new InvoiceReport();
            report.Parameters["IDParameter"].Value = invoiceId;
            report.Parameters["IDParameter"].Visible = false;
            return View(report);
        }

        public ActionResult ShowIssued(int? invoiceId)
        {
            var report = new ReleaseReport();
            report.Parameters["IDParameter"].Value = invoiceId;
            report.Parameters["IDParameter"].Visible = false;
            return View(report);
        }
        public ActionResult ShowCancelled(int? invoiceId)
        {
            var report = new CancelledReport();
            report.Parameters["IDParameter"].Value = invoiceId;
            report.Parameters["IDParameter"].Visible = false;
            return View(report);
        }
        public ActionResult ShowReplace(int? invoiceId)
        {
            var report = new ReplaceReport();
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