using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using DevExpress.XtraPrinting.Native;
using EInvoice.Data.Data;
using EInvoice.Data.Services;
using EInvoice.Service;
using EInvoice.Web.Models;

namespace EInvoice.Web.Controllers.CategoryController
{
    [PermissionLogin]
    public class ProductController : Controller
	{
		private readonly IProductService _productService;
		private readonly IUnitService _unitService;

		public ProductController(IProductService productService, IUnitService unitService)
		{
			_productService = productService;
			_unitService = unitService;
		}

		// GET: Product

		public ActionResult Index()
		{
			return View();
		}
		public IEnumerable<Unit> GetAllUnit()
		{
			return _unitService.GetAll();
		}

		[ValidateInput(false)]
		public ActionResult ProductPartial()
		{
			var model = Mapper.Map<List<ProductViewModel>>(_productService.GetAllDesProduct());
			return PartialView("_ProductPartial", model);
		}

		[HttpPost, ValidateInput(false)]
		public ActionResult ProductPartialAddNew(Product product)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_productService.AddProduct(product);
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			else
				ViewData["EditError"] = "Please, correct all errors.";

			return ProductPartial();
		}

		[HttpPost, ValidateInput(false)]
		public ActionResult ProductPartialUpdate(Product product)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_productService.Update(product);
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}
			else
				ViewData["EditError"] = "Please, correct all errors.";

			return ProductPartial();
		}

		[HttpPost, ValidateInput(false)]
		public ActionResult ProductPartialDelete(int ID)
		{
			if (ID >= 0)
			{
				try
				{
					_productService.DeleteByID(ID);
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}

			return ProductPartial();
		}

		[HttpPost]
		public JsonResult GetProducts(string searchKey)
		{
			var products = Mapper.Map<List<ProductViewModel>>(_productService.GetProductsSource());
			var searchProducts = products.Where(x => x.Name.Contains(searchKey)).ToList();
			searchProducts.ForEach(_ => _.Unit.Products = null);

			return Json(searchProducts, JsonRequestBehavior.AllowGet);
		}
	}
}
