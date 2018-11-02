using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;
using EInvoice.Repository;

namespace EInvoice.Service
{
	public class InvoiceService : BaseService<Invoice>, IInvoiceService
	{

		public InvoiceService(IRepository<Invoice> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
		{
			repository.DeleteDraftInvoice("test");
		}

		public void AddDraft(Invoice invoice)
		{
			
		}
	}
}