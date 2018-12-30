using EInvoice.Data.Services;
using EInvoice.Data.Utilities;
using System;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers.CategoryController
{
    [PermissionLogin]
    public partial class CategoryController : Controller
    {
        private readonly IUnitService _unitService;

        public CategoryController(IUnitService unitService, IProductService productService, ICustomerService customerService)
        {
            _unitService = unitService;
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