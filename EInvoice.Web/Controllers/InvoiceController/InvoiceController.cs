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

		//[HttpPost]
		//public ActionResult Create(NewInvoiceViewModel model)
		//{
		//	model.Invoice.CustomerId = _customerService.GetId(model.Customer);
		//	var items = SetInvoiceItem(model.Invoice);
		//	model.Invoice.Items = items;
		//	_invoiceService.AddDraft(model.Invoice);

		//	return View(model);
		//}

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

		//public void SetInvoiceCompany(Invoice invoice)
		//{
		//	var company = _companyService.GetAll().First();
		//	invoice.CompanyId = company.ID;
		//}

		//public void SetInvoiceCustomer(Invoice invoice)
		//{
		//	Customer customer = null;
		//	customer = _customerService.GetAll()
		//		.FirstOrDefault(x => x.Code == invoice.Customer.Code);

		//	if (customer != null)
		//	{
		//		invoice.CustomerId = customer.ID;
		//	}
		//	else
		//	{
		//		customer = invoice.Customer;
		//		_customerService.AddCustomer(customer);
		//		invoice.CustomerId = customer.ID;
		//	}
		//}

		//public void SetInvoicePayment(Invoice invoice)
		//{
		//	var paymentMethod = _paymentMethodService.GetAll()
		//		.FirstOrDefault(x => x.Name == invoice.PaymentMethod.Name);
		//	invoice.PaymentTypeID = paymentMethod.ID;
		//}

		//public IList<Item> SetInvoiceItem(Invoice invoice)
		//{
		//	var items = new List<Item>(invoice.Items);
		//	for (int i = 0; i < items.Count(); i++)
		//	{
		//		var product = _productService.GetAll().FirstOrDefault(x => x.Code == items[i].Product.Code);
		//		if (product != null)
		//		{
		//			items[i].ProductId = product.ID;
		//		}
		//		else
		//		{
		//			var getUnit = GetUnit(items[i].Product.Unit.Name);
		//			if (getUnit != null)
		//			{
		//				items[i].Product.UnitID = getUnit.ID;
		//				items[i].Product.Unit = null;
		//				AddNewItemProduct(items[i].Product);
		//			}
		//			else
		//			{
		//				var newUnit = new Unit();
		//				newUnit.Name = items[i].Product.Unit.Name;
		//				_unitService.Add(newUnit);
		//				items[i].Product.UnitID = GetUnit(newUnit.Name).ID;
		//				items[i].Product.Unit = null;
		//				AddNewItemProduct(items[i].Product);
		//			}
		//			items[i].ProductId = items[i].Product.ID;
		//		}
		//		items[i].Product = null;
		//	}

		//	return items;
		//}

		//private void AddNewItemProduct(Product product)
		//{
		//	var maxProductId = _productService.GetAll().Last().ID;
		//	var index = maxProductId + 1;
		//	var randomCode = "SP" + index;
		//	var newProduct = product;
		//	newProduct.Code = randomCode;
		//	// Need to check again when add new product -> maybe split number behind product Code
		//	_productService.Add(newProduct);
		//}

		//private Unit GetUnit(string unitName)
		//{
		//	var checkUnit = _unitService.GetAll().FirstOrDefault(x => x.Name == unitName);

		//	return checkUnit;
		//}

		public IList<PaymentMethod> GetPayments()
		{
			return _paymentMethodService.GetAll();
		}
	}
}