using EInvoice.Data.Data;

namespace EInvoice.Data.Services
{
	public interface IInvoiceService : IBaseService<Invoice>
	{
		void AddDraft(Invoice invoice);

		void UpdateInvoice(Invoice invoice);
		void DeleteInvoice(int id);
		void ChangeStatus(int invoiceId);
	}
}