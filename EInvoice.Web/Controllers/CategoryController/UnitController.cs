﻿using Data.Utilities;
using EInvoice.Data.Data;
using EInvoice.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers.CategoryController
{
    [PermissionLogin]
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
			var model = _unitService.GetUnits();
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
		public ActionResult UnitPartialDelete(int id)
		{
			if (id >= 0)
			{
				try
				{
					_unitService.DeleteUnit(id);
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