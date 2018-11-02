using AutoMapper;
using EInvoice.Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using EInvoice.Data.Data;
using EInvoice.Data.Services;

namespace EInvoice.Web.Controllers.InvoiceController
{
	public partial class InvoiceController : Controller
	{
		private readonly IPatternService _patternService;
		public InvoiceController(IPatternService patternService)
		{
			_patternService = patternService;
		}
		public ActionResult DraftInvoice()
		{
			return View();
		}

		public ActionResult _DraftInvoice()
		{
			var model = Mapper.Map<List<InvoiceViewModel>>(_invoiceService.GetAll());
			return PartialView("_DraftInvoice", model);
		}

		public IEnumerable<Pattern> GetPattern()
		{
			return _patternService.GetAll();
		}

	
		//[HttpPost, ValidateInput(false)]
		//public ActionResult EditDraft(Invoice invoice)
		//{
		//	if (ModelState.IsValid)
		//		SafeExecute(() => NorthwindDataProvider.UpdateProduct(product));
		//	else
		//	{
		//		ViewData["EditError"] = "Please, correct all errors.";
		//		ViewData["EditableProduct"] = product;
		//	}
		//	return EditFormTemplatePartial();
		//}
		//[HttpPost, ValidateInput(false)]
		//public ActionResult DeleteDraft(int invoiceId)
		//{
		//	if (productID > 0)
		//		SafeExecute(() => NorthwindDataProvider.DeleteProduct(productID));
		//	return EditFormTemplatePartial();
		//}

	}
}