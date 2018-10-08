using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Implementation;
using EInvoice.Data.Infrastructure.Interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EInvoice.Data.Repositories
{
	public interface IProductRepository : IRepository<Product>
	{
		IList<Product> GetAllDes();
		IEnumerable<Product> GetByInvoiceID(long invoiceID);
	}

	public class ProductRepository : BaseRepository<Product>, IProductRepository
	{
		private IDbFactory _dbFactory;
		private readonly IDbSet<Product> _dbSet;

		public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
		{
			_dbFactory = dbFactory;
			_dbSet = DbContext.Set<Product>();
		}

		public IList<Product> GetAllDes()
		{
			return _dbSet.OrderByDescending(c => c.ID).ToList();
		}

		public IEnumerable<Product> GetByInvoiceID(long invoiceID)
		{
			throw new System.NotImplementedException();
		}
	}
}