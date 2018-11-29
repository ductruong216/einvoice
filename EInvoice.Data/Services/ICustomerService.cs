using System;
using EInvoice.Data.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EInvoice.Data.Services
{
	public interface ICustomerService : IBaseService<Customer>
	{
		void AddCustomer(Customer customer);
		IList<Customer> GetCustomers();
		void DeleteCustomer(int id);
		long GetId(Customer customer);
		IList<Customer> GetCustomerByTaxCode(string searchKey);
		IList<Customer> GetCustomerByCode(string searchKey);
		IList<Customer> GetCustomerByName(string searchKey);
	}
}