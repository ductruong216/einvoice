using AutoMapper;
using EInvoice.Data.Data;
using EInvoice.Data.Services;
using EInvoice.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers.CategoryController
{
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
		public ActionResult ProductPartialDelete(int id)
		{
			if (id >= 0)
			{
				try
				{
					_productService.DeleteProduct(id);
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
			var searchProducts = products.Where(x => x.Name.Contains(searchKey) && x.isDel == false).ToList();
			searchProducts.ForEach(_ => _.Unit.Products = null);

			return Json(searchProducts, JsonRequestBehavior.AllowGet);
		}
	}
}