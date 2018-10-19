using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;

namespace EInvoice.Service
{
	public class CompanyService : BaseService<Company>, ICompanyService
	{
		public CompanyService(IRepository<Company> companyRepository, IUnitOfWork unitOfWork) : base(companyRepository, unitOfWork)
		{
		}
	}
}