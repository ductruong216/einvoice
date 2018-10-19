using EInvoice.Data.Data;
using EInvoice.Data.Services;
using System;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers
{
	public class CompanyController : Controller
	{
		private ICompanyService _companyService;

		public CompanyController(ICompanyService companyService)
		{
			_companyService = companyService;
		}

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult UpdateCompany(Company company)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_companyService.Update(company);
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			else
				ViewData["EditError"] = "Please, correct all errors.";

			return Index();
		}
	}
}