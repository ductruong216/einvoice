using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EInvoice.Repository
{
	public static class ProductRepository
	{
		public static IList<Product> GetAllDes(this IRepository<Product> repository)
		{
			return repository.DbSet.OrderByDescending(c => c.ID).ToList();
			//return OrderByDescending(c => c.ID).ToList();
		}

		public static IEnumerable<Product> GetByInvoiceID(this IRepository<Product> repository, long invoiceID)
		{
			throw new System.NotImplementedException();
		}

		public static IDbSet<Product> ProductSource(this IRepository<Product> repository)
		{
			return repository.DbSet;
		}
	}
}