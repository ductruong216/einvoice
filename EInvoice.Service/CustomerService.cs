using EInvoice.Common;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EInvoice.Service
{
	public class CustomerService : BaseService<Customer>, ICustomerService
	{
		private readonly IRepository<Customer> _customerRepository;

		public CustomerService(IRepository<Customer> customerRepository, IUnitOfWork unitOfWork) : base(customerRepository, unitOfWork)
		{
			_customerRepository = customerRepository;
		}

		public bool IsUniq(string code)
		{
			return _customerRepository.CheckContains(x => x.Code == code);
		}

		public bool IsTaxExist(long taxCode)
		{
			return _customerRepository.CheckContains(x => x.TaxCode == taxCode);
		}

		public void AddCustomer(Customer customer)
		{
			if (_customerRepository.CheckContains(x => x.TaxCode == customer.TaxCode) &&
				_customerRepository.CheckContains(i => i.Code == customer.Code))
			{
				throw new NameDuplicatedException("Both Tax Code and Customer Code are exist");
			}
			if (_customerRepository.CheckContains(x => x.Code == customer.Code) &&
				_customerRepository.CheckContains(i => i.TaxCode != customer.TaxCode))
			{
				throw new NameDuplicatedException("Customer code is exist");
			}
			if (_customerRepository.CheckContains(x => x.TaxCode == customer.TaxCode) &&
				_customerRepository.CheckContains(i => i.Code != customer.Code))
			{
				throw new NameDuplicatedException("Tax code is exist");
			}

			Add(customer);
		}

		public IList<Customer> GetCustomers()
		{
			return _customerRepository.GetAll().Where(x => x.isDel == false).ToList();
		}

		public IDbSet<Customer> CustomerDbSet()
		{
			return _customerRepository.DbSet;
		}

		public void DeleteCustomer(int id)
		{
			var customer = GetSingleById(id);
			customer.isDel = true;
			Update(customer);
		}

		public long GetId(Customer customer)
		{
			var findCustomer = _customerRepository.GetAll().FirstOrDefault(x => x.Code == customer.Code);

			if (findCustomer != null)
			{
				return findCustomer.ID;
			}
			_customerRepository.Add(customer);

			return _customerRepository.GetAll().Last().ID;
		}
	}
}