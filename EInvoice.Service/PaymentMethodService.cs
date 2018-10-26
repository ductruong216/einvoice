using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;

namespace EInvoice.Service
{
	public class PaymentMethodService : BaseService<PaymentMethod>, IPaymentMethodService
	{
		public PaymentMethodService(IRepository<PaymentMethod> paymentMethodRepository, IUnitOfWork unitOfWork) : base(
			paymentMethodRepository, unitOfWork)
		{
		}
	}
}