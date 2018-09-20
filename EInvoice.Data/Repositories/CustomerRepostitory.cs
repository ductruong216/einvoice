using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Implementation;
using EInvoice.Data.Infrastructure.Interface;
using System.Collections.Generic;

namespace EInvoice.Data.Repositories
{
	public interface ICustomerRepository : IRepository<Customer>
	{

	}

	public class CustomerRepostitory : BaseRepository<Customer>, ICustomerRepository
	{
		public CustomerRepostitory(IDbFactory dbFactory) : base(dbFactory)
		{
		}
	}
}