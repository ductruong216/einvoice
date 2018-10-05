﻿using AutoMapper;
using EInvoice.Web.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Customer = EInvoice.Data.Data.Customer;

namespace EInvoice.Web.Controllers.CategoryController
{
	public partial class CategoryController
	{
		public ActionResult Customers()
		{
			return View();
		}

		[ValidateInput(false)]
		public ActionResult CustomerPartial()
		{
			var model = Mapper.Map<List<CustomerViewModel>>(_customerService.GetAll());
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
					_customerService.Save();
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
					_customerService.Save();
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
		public ActionResult  CustomerPartialDelete(string customerID)
		{
			if (customerID != null)
			{
				try
				{
					_customerService.DeleteByID(customerID);
					_customerService.Save();
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}

			return CustomerPartial();
		}

		[HttpPost]
		public JsonResult IsCustomerCodeUniq(string code)
		{
			bool isUniq = _customerService.IsUniq(code);
			return Json(!isUniq);
		}

		[HttpPost]
		public JsonResult IsCustomerTaxCodeUniq(long taxCode)
		{
			bool isUniq = _customerService.IsTaxExist(taxCode);
			return Json(!isUniq);
		}
	}
}