using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Implementation;
using EInvoice.Data.Infrastructure.Interface;

namespace EInvoice.Data.Repositories
{
	public interface IInvoiceRepository : IRepository<Invoice>
	{
	}

	public class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
	{
		public InvoiceRepository(IDbFactory dbFactory) : base(dbFactory)
		{
		}
	}
}