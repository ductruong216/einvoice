using EInvoice.Data.Data;
using EInvoice.Data.Services;
using EInvoice.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
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

		[HttpPost]
		public void Create(Invoice invoice)
		{
			try
			{
				_invoiceService.AddDraft(invoice);
			}
			catch (Exception e)
			{
				ViewData["EditError"] = e.Message;
			}
		}

		public IList<PaymentMethod> GetPayments()
		{
			return _paymentMethodService.GetAll();
		}
	}
}