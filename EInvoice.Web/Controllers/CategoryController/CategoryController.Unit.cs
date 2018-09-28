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
		// GET: Category
		

		public IEnumerable<Unit> GetAllUnit()
		{
			return _unitService.GetAll();
		}

		[ValidateInput(false)]
		public ActionResult UnitPartial()
		{
			var model = _unitService.GetAll();
			return PartialView("_UnitPartial", model);
		}

		[HttpPost, ValidateInput(false)]
		public ActionResult UnitPartialAddNew(Unit unit)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_unitService.Add(unit);
					_unitService.Save();
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

			return UnitPartial();
		}

		[HttpPost, ValidateInput(false)]
		public ActionResult UnitPartialUpdate(Unit unit)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_unitService.Update(unit);
					_unitService.Save();
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			else
				ViewData["EditError"] = "Please, correct all errors.";

			return UnitPartial();
		}

		[HttpPost, ValidateInput(false)]
		public ActionResult UnitPartialDelete(int UnitID)
		{
			if (UnitID >= 0)
			{
				try
				{
					_unitService.DeleteByID(UnitID);
					_unitService.Save();
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
		
			return UnitPartial();
		}
	}
}