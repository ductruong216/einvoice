using System;

namespace EInvoice.Data.Infrastructure.Interface
{
	public interface IDbFactory : IDisposable
	{
		//InvoiceEntities Init();
		int SaveChanges();
	}
}