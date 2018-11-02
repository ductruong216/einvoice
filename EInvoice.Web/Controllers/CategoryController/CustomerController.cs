using AutoMapper;
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
		public ActionResult CustomerPartialAddNew(Customer customer)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_customerService.AddCustomer(customer);
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			else
				ViewData["EditError"] = "Please, correct all errors.";

			return CustomerPartial();
		}

		[HttpPost, ValidateInput(true)]
		public ActionResult CustomerPartialUpdate(Customer customer)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_customerService.Update(customer);
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			else
				ViewData["EditError"] = "Please, correct all errors.";

			return CustomerPartial();
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
			var customers = _customerService.CustomerDbSet();
			var searchCustomer = customers.Where(x => x.Code.Contains(searchKey) && x.isDel == false).ToList();
			return Json(searchCustomer, JsonRequestBehavior.AllowGet);
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
				Purchaser = x.Purchaser,
				Address = x.Address,
				Email = x.Email,
				Phone = x.Phone,
				Fax = x.Fax,
				LegalPresenter = x.LegalPresenter,
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