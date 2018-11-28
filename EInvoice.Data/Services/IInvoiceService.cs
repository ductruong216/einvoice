using System.Collections.Generic;
using EInvoice.Data.Data;

namespace EInvoice.Data.Services
{
	public interface IInvoiceService : IBaseService<Invoice>
	{
		void AddDraft(Invoice invoice);

		void UpdateInvoice(Invoice invoice);
		void DeleteInvoice(int id);
		void Release(int invoiceId);
		IList<Serial> GetSeries();
		IEnumerable<Serial> GetSeriesByPattern(int id);
	}
}