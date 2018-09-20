using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Repositories;

namespace EInvoice.Service
{
	public interface ICustomerService : IBaseService<Customer>
	{

	}

	public class CustomerService : BaseService<Customer>, ICustomerService
	{
		public CustomerService(ICustomerRepository customerRepository, IUnitOfWork unitOfWork) : base(customerRepository, unitOfWork)
		{

		}
	}
}