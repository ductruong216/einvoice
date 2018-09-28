using EInvoice.Data.Data;
using System;
using System.Data.Entity.Validation;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers.CategoryController
{
	public partial class CategoryController : Controller
	{
		// GET: Category

		[ValidateInput(false)]
		public ActionResult ProductPartial()
		{
			var model = _productService.GetAllDesProduct();
			return PartialView("_ProductPartial", model);
		}

		[HttpPost, ValidateInput(false)]
		public ActionResult ProductPartialAddNew(Product product)
		{
			if (ModelState.IsValid)
			{
				try
				{
					_productService.Add(product);
					_productService.Save();
				}
				catch (DbEntityValidationException e)
				{
					throw e;
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
	}
}