using AutoMapper;
using EInvoice.Data.Data;
using EInvoice.Data.Services;
using EInvoice.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Customer = EInvoice.Data.Data.Customer;

namespace EInvoice.Web.Controllers.CategoryController
{
	public class CustomerController : Controller
	{
		private readonly ICustomerService _customerService;

		public CustomerController(ICustomerService customerService)
		{
			_customerService = customerService;
		}

		public ActionResult Index()
		{
			return View();
		}

		[ValidateInput(false)]
		public ActionResult CustomerPartial()
		{
			var model = Mapper.Map<List<CustomerViewModel>>(_customerService.GetCustomers());
			return PartialView("_CustomerPartial", model);
		}

		[HttpPost, ValidateInput(true)]
		public ActionResult Create(CustomerViewModel customer)
		{
			if (ModelState.IsValid)
			{
				try
				{
					var newCustomer = Mapper.Map<Customer>(customer);
					_customerService.AddCustomer(newCustomer);
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			else
				ViewData["EditError"] = "Please, correct all errors.";

			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult Edit(int id)
		{
			var customer = Mapper.Map<CustomerViewModel>(_customerService.GetSingleById(id));
			return View(customer);
		}
		[HttpPost, ValidateInput(false)]
		public ActionResult Edit(Employee customer)
		{
			if (ModelState.IsValid)
			{
				try
				{
					var newCustomer = Mapper.Map<Customer>(customer);
					_customerService.Update(newCustomer);
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			else
				ViewData["EditError"] = "Please, correct all errors.";

			return RedirectToAction("Index");
		}

		[HttpPost, ValidateInput(false)]
		public ActionResult CustomerPartialDelete(int id)
		{
			if (id >= 0)
			{
				try
				{
					_customerService.DeleteCustomer(id);
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}

			return CustomerPartial();
		}

		[HttpPost]
		public JsonResult GetCodeCustomerJsonResult(string searchKey)
		{
			//var db = new InvoiceEntities();
			var customers = _customerService.GetAll();
			var searchCustomer = customers.Where(x => x.Code.Contains(searchKey) && x.isDel == false).ToList();
			return Json(searchCustomer, JsonRequestBehavior.AllowGet);
		}

		[HttpPost]
		public JsonResult CheckCode(string searchKey)
		{
			var db = new InvoiceEntities();
			//var customers = _customerService.GetAll();
			var isAny = db.Customers.Any(x => x.Code == searchKey && x.isDel == false);
			if (!isAny)
			{
				return Json(false, JsonRequestBehavior.AllowGet);
			}
			else
			{
				return Json(true, JsonRequestBehavior.AllowGet);
			}
		}

		[HttpPost]
		public JsonResult CheckTaxCode(string searchKey)
		{
			var customers = _customerService.GetAll();
			var isAny = customers.Any(x => x.TaxCode == searchKey && x.isDel == false);
			if (!isAny)
			{
				return Json(false, JsonRequestBehavior.AllowGet);
			}
			else
			{
				return Json(true, JsonRequestBehavior.AllowGet);
			}
		}

		[HttpPost]
		public JsonResult GetNameCustomerJsonResult(string searchKey)
		{
			var customers = _customerService.CustomerDbSet();
			var searchCustomer = customers.Where(x => x.Name.Contains(searchKey) && x.isDel == false).ToList();
			return Json(searchCustomer, JsonRequestBehavior.AllowGet);
		}

		[HttpPost]
		public JsonResult GetTaxCodeCustomerJsonResult(string searchKey)
		{
			var customers = _customerService.CustomerDbSet();
			var searchCustomer = customers.Where(x => x.TaxCode.ToString().Contains(searchKey) && x.isDel == false).Select(x => new Customer
			{
				ID = x.ID,
				Code = x.Code,
				TaxCode = x.TaxCode,
				Name = x.Name,
				EnterpriseName = x.EnterpriseName,
				Address = x.Address,
				Email = x.Email,
				Phone = x.Phone,
				Fax = x.Fax,
				LegalRepresentative = x.LegalRepresentative,
				AccountHolder = x.AccountHolder,
				BankAccountID = x.BankAccountID,
				BankName = x.BankName,
				Agency = x.Agency,
				Note = x.Note
			}).ToList();
			return Json(searchCustomer, JsonRequestBehavior.AllowGet);
		}

		//[HttpGet]
		//public JsonResult GetCustomerAPI(string mst)
		//{
		//	string customerAPI = "https://thongtindoanhnghiep.co/api/company/" + mst;
		//	var client = new RestClient(customerAPI);
		//	return Json(client, JsonRequestBehavior.AllowGet);
		//}
	}
}