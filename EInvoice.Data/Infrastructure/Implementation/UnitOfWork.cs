using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using System;

namespace EInvoice.Data.Infrastructure.Implementation
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly IDbFactory _dbFactory;
		private InvoiceEntities _dbContext;
		public InvoiceEntities DbContext
		{
			get
			{
				return _dbContext ?? (_dbContext = _dbFactory.Init());
			}
		}

		public UnitOfWork(IDbFactory dbFactory)
		{
			_dbFactory = dbFactory;
		}
		public void Commit()
		{
			DbContext.SaveChanges();
		}
	}
}