﻿using EInvoice.Data.Services;
using System;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers.CategoryController
{
	public partial class CategoryController : Controller
	{
		private readonly IUnitService _unitService;
		private readonly IProductService _productService;
		private readonly ICustomerService _customerService;

		public CategoryController(IUnitService unitService, IProductService productService, ICustomerService customerService)
		{
			_unitService = unitService;
			_productService = productService;
			_customerService = customerService;
		}

		// GET: Category

		public void SafeExecute(Action method)
		{
			try
			{
				method();
			}
			catch (Exception e)
			{
				ViewData["EditError"] = e.Message;
			}
		}

		public ActionResult Others()
		{
			return View();
		}

		[ValidateInput(false)]
		public ActionResult UnitPartial()
		{
			var model = _unitService.GetAll();
			return PartialView("_UnitPartial", model);
		}
	}
}