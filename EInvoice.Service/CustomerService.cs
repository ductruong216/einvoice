using System.Data.Entity;
using EInvoice.Common;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;

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

		public IDbSet<Customer> CustomerDbSet()
		{
			return _customerRepository.DbSet;
		}



	}
}