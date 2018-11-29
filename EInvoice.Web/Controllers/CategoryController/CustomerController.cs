﻿using AutoMapper;
using EInvoice.Data.Data;
using EInvoice.Data.Services;
using EInvoice.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
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
		public void Create(CustomerViewModel customer)
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

		[HttpGet]
		public ActionResult Edit(int id)
		{
			var customer = Mapper.Map<CustomerViewModel>(_customerService.GetSingleById(id));
			return View(customer);
		}

		[HttpPost]
		public ActionResult Edit(Customer customer)
		{
			try
			{
				_customerService.Update(customer);
				return Content("SUCCESS", "application/json");
			}
			catch (Exception e)
			{
				ViewData["EditError"] = e.Message;
				return Content("FAIL", "application/json");
			}
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
		public JsonResult GetCustomerByCode(string searchKey)
		{
			var searchCustomer = Mapper.Map<List<CustomerViewModel>>
				(_customerService.GetCustomerByCode(searchKey));
			return Json(searchCustomer, JsonRequestBehavior.AllowGet);
		}
		[HttpPost]
		public JsonResult GetCustomerByName(string searchKey)
		{
			var searchCustomer = Mapper.Map<List<CustomerViewModel>>
				(_customerService.GetCustomerByName(searchKey));
			return Json(searchCustomer, JsonRequestBehavior.AllowGet);
		}

		[HttpPost]
		public JsonResult GetCustomerByTaxCode(string searchKey)
		{
			var searchCustomer = Mapper.Map<List<CustomerViewModel>>
				(_customerService.GetCustomerByTaxCode(searchKey));

			return Json(searchCustomer, JsonRequestBehavior.AllowGet);
		}

		public JsonResult Success()
		{
			return Json(new { Success = true, Message = "" }, JsonRequestBehavior.AllowGet);
		}

		public JsonResult Error(string message)
		{
			return Json(new { Success = false, Message = message }, JsonRequestBehavior.AllowGet);
		}
	}
}