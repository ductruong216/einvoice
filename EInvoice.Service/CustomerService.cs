using System;
using EInvoice.Common;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;

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

		public void AddCustomer(Customer customer)
		{
			//if (_customerRepository.CheckContains(x => x.TaxCode == customer.TaxCode) &&
			//	_customerRepository.CheckContains(i => i.Code == customer.Code))
			//{
			//	throw new NameDuplicatedException("Both Tax Code and Customer Code are exist");
			//}
			//if (_customerRepository.CheckContains(x => x.Code == customer.Code) &&
			//	_customerRepository.CheckContains(i => i.TaxCode != customer.TaxCode))
			//{
			//	throw new NameDuplicatedException("Customer code is exist");
			//}
			//if (_customerRepository.CheckContains(x => x.TaxCode == customer.TaxCode) &&
			//	_customerRepository.CheckContains(i => i.Code != customer.Code) && customer.Code != null
			//	)
			//{
			//	throw new NameDuplicatedException("Tax code is exist");
			//}

			Add(customer);
		}

		public IList<Customer> GetCustomers()
		{
			return _customerRepository.GetMulti(x => x.isDel == false).OrderByDescending(c => c.ID).ToList();
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

		public IList<Customer> GetCustomerByTaxCode(string taxCode)
		{
			return _customerRepository.GetMulti(x => x.TaxCode.Contains(taxCode) && x.isDel == false).ToList();
		}

		public IList<Customer> GetCustomerByCode(string code)
		{
			return _customerRepository.GetMulti(x => x.Code.Contains(code) && x.isDel == false).ToList();
		}

		public IList<Customer> GetCustomerByName(string enterpriseName)
		{
			return _customerRepository.GetMulti(x => x.EnterpriseName.Contains(enterpriseName) && x.isDel == false).ToList();
		}
	}
}