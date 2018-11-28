using EInvoice.Data.Data;
using EInvoice.Data.Services;
using EInvoice.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Office.Utils;
using Customer = EInvoice.Data.Data.Customer;

namespace EInvoice.Web.Controllers.InvoiceController
{
	public partial class InvoiceController : Controller
	{
		private readonly IInvoiceService _invoiceService;
		private readonly IPaymentMethodService _paymentMethodService;
		private readonly ICompanyService _companyService;
		private readonly ICustomerService _customerService;
		private readonly IProductService _productService;
		private readonly IUnitService _unitService;
		private readonly IPatternService _patternService;
		private readonly IItemService _itemService;

		public InvoiceController(IInvoiceService invoiceService,
								 IPaymentMethodService paymentMethodService,
								 ICompanyService companyService,
								 ICustomerService customerService,
								 IProductService productService,
								 IUnitService unitService,
								 IPatternService patternService,
								 IItemService itemService
								)
		{
			_invoiceService = invoiceService;

			_paymentMethodService = paymentMethodService;
			_companyService = companyService;
			_customerService = customerService;
			_productService = productService;
			_unitService = unitService;
			_patternService = patternService;
			_itemService = itemService;
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
		
		public JsonResult Create(Invoice invoice)
		{
			try
			{
				_invoiceService.AddDraft(invoice);
				return Success("Successfully");
			}
			catch (Exception e)
			{
				return Error(e.Message);
			}
		}

		public IList<PaymentMethod> GetPayments()
		{
			return _paymentMethodService.GetAll();
		}

		public JsonResult Success(string message)
		{
			return Json(new { Success = true, Message = message }, JsonRequestBehavior.AllowGet);
		}

		public JsonResult Error(string message)
		{
			return Json(new { Success = false, Message = message }, JsonRequestBehavior.AllowGet);
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
		public JsonResult GetSerial(int patternId)
		{
			return Json(GetSeries(patternId), JsonRequestBehavior.AllowGet);
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

		public IEnumerable<Pattern> GetPattern()
		{
			return _patternService.GetAll();
		}

		public IEnumerable<Serial> GetAllSerial()
		{
			return _invoiceService.GetSeries();
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
	}
}