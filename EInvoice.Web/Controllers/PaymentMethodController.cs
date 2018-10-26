using EInvoice.Data.Data;
using EInvoice.Data.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EInvoice.Web.Controllers
{
	public class PaymentMethodController : Controller
	{
		private readonly IPaymentMethodService _paymentMethodService;

		public PaymentMethodController(IPaymentMethodService paymentMethodService)
		{
			_paymentMethodService = paymentMethodService;
		}

		// GET: Payment
		//public IList<PaymentMethod> GetPayments()
		//{
		//	return View();
		//}
	}
}