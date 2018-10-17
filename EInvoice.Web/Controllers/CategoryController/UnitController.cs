using EInvoice.Data.Data;
using EInvoice.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EInvoice.Data.Services;

namespace EInvoice.Web.Controllers.CategoryController
{
	public class UnitController : Controller
	{
		private readonly IUnitService _unitService;

		public UnitController(IUnitService unitService)
		{
			_unitService = unitService;
		}

		public ActionResult Index()
		{
			return View();
		}

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
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}

			return UnitPartial();
		}

		[HttpPost]
		public JsonResult GetUnits(string searchKey)
		{
			var products = _unitService.GetAll();
			var searchProducts = products.Where(x => x.Name.Contains(searchKey)).Select(x => new Unit
			{
				ID = x.ID,
				Name = x.Name
			}).ToList();
			return Json(searchProducts, JsonRequestBehavior.AllowGet);
		}
	}
}