using EInvoice.Data.Data;
using System.Collections.Generic;
using System.Data.Entity;

namespace EInvoice.Data.Services
{
	public interface ICustomerService : IBaseService<Customer>
	{
		void AddCustomer(Customer customer);

		IList<Customer> GetAll();

		IDbSet<Customer> CustomerDbSet();
	}
}