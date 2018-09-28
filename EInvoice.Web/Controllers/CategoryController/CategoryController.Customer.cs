using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EInvoice.Data.Data;
using EInvoice.Service;

namespace EInvoice.Web.Controllers.CategoryController
{
	public partial class CategoryController
	{
		
		[ValidateInput(false)]
		public ActionResult CustomerPartial()
		{
			var model = _customerService.GetAll();
			return PartialView("_CustomerPartial", model);
		}

		[HttpPost, ValidateInput(false)]
		public ActionResult CustomerPartialAddNew(Customer customer)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_customerService.Add(customer);
					_customerService.Save();
				}
				catch (DbEntityValidationException e)
				{
					throw e;
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
	}
}