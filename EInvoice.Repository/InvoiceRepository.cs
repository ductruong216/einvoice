using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;

namespace EInvoice.Repository
{
	public static class InvoiceRepository
	{
		public static bool DeleteDraftInvoice(this IRepository<Invoice> repository, string invoiceNo)
		{
			return true;
		}
	}
}