using System.Collections;
using System.Collections.Generic;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Repositories;

namespace EInvoice.Service
{
	public interface IInvoiceService : IBaseService<Invoice>
	{
	}

	public class InvoiceService : BaseService<Invoice>, IInvoiceService
	{
		private IInvoiceRepository _invoiceRepository { get; set; }
		private IUnitOfWork _unitOfWork { get; set; }

		public InvoiceService(IInvoiceRepository invoiceRepository, IUnitOfWork unitOfWork) : base(invoiceRepository, unitOfWork)
		{
			_invoiceRepository = invoiceRepository;
			_unitOfWork = unitOfWork;
		}

	
	}
}