using AutoMapper;
using EInvoice.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EInvoice.Data.Data;
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
		public ActionResult CustomerPartialDelete(string customerID)
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

		[HttpPost]
		public JsonResult GetCustomerJsonResult(string searchKey)
		{
			var dn = new InvoiceEntities();
			var searchCustomer = dn.Customers.Where(x => x.Code.Contains(searchKey)).Select(x => new Customer
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
			return new JsonResult { Data = searchCustomer, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
		}
		//var customers = _customerService.GetAll();
		//var searchCustomer = customers
	}
}