using EInvoice.Data.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using EInvoice.Web.Models;

namespace EInvoice.Web.Controllers.CategoryController
{
	public partial class CategoryController : Controller
	{
		// GET: Category
		public ActionResult Products()
		{
			return View();
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
					_productService.Save();
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
					_productService.Save();
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
		public ActionResult ProductPartialDelete(string ProductID)
		{
			if (ProductID != null)
			{
				try
				{
					_productService.DeleteByID(ProductID);
					_productService.Save();
				}
				catch (Exception e)
				{
					ViewData["EditError"] = e.Message;
				}
			}

			return ProductPartial();
		}

		[HttpPost]
		public JsonResult IsProductCodeUniq(string code)
		{
			bool isUniq = _productService.IsUniq(code);
			return Json(!isUniq);
		}
		[HttpPost]
		public JsonResult GetProducts(string searchKey)
		{
			var products = _productService.GetAll();
			var searchProducts = products.Where(x => x.Name.Contains(searchKey)).Select(x => new Product
			{
				ID = x.ID,
				Code = x.Code,
				Name = x.Name,
				Price = x.Price,
				Tax = x.Tax,
			}).ToList();
			return Json(searchProducts, JsonRequestBehavior.AllowGet);
		}
	}
}