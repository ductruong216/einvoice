using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using System;

namespace EInvoice.Data.Infrastructure.Implementation
{
	public class DbFactory : IDbFactory
	{
		private InvoiceEntities dbContext;
		public InvoiceEntities Init()
		{
			return dbContext ?? (dbContext = new InvoiceEntities());
		}

		public void Dispose()
		{
			if (dbContext != null)
				dbContext.Dispose();
		}
	}
}