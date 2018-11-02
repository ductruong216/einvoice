using System.Data.Entity;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;

namespace EInvoice.Data.Infrastructure.Implementation
{
	public class DbFactory : DbContext, IDbFactory
	{
		public DbFactory(string connectionName)
			: base(connectionName)
		{
		}

		//public InvoiceEntities Init()
		//{
		//	return _dbContext ?? (_dbContext = new InvoiceEntities());
		//}

		public void Dispose()
		{
			base.Dispose();
		}

		public void SaveChanges()
		{
			base.SaveChanges();
		}
	}
}