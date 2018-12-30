using AutoMapper;
using Data.Utilities.Enumeration;
using EInvoice.Data.Data;
using EInvoice.Data.Services;
using EInvoice.Data.Utilities;
using EInvoice.Web.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers
{
    [Auth(Enumerations.Role.Accountant)]
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

        [HttpPost]
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