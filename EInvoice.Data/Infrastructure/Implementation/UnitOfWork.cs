using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;

namespace EInvoice.Data.Infrastructure.Implementation
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly IDbFactory _dbFactory;
		private InvoiceEntities _dbContext;

	

		public UnitOfWork(IDbFactory dbFactory)
		{
			_dbFactory = dbFactory;
		}


		public void SaveChanges()
		{
			_dbFactory.SaveChanges();
		}
	}
}