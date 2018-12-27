﻿using AutoMapper;
using Data.Utilities;
using EInvoice.Data.Data;
using EInvoice.Data.Services;
using EInvoice.Web.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers
{
    [PermissionLogin]
    public class CompanyInfoController : Controller
	{
		private readonly ICompanyService _companyService;

		public CompanyInfoController(ICompanyService companyService)
		{
			_companyService = companyService;
		}

		public ActionResult Index()
		{
			var model = Mapper.Map<CompanyViewModel>(_companyService.GetAll().First());
			return View(model);
		}

		public ActionResult Update(Company company)
		{
			try
			{
				_companyService.UpdateCompany(company);
			}
			catch (Exception e)
			{
				ViewData["EditError"] = e.Message;
			}

			return RedirectToAction("Index");
		}
	}
}