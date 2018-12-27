using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;

namespace EInvoice.Service
{
	public class CompanyService : BaseService<Company>, ICompanyService
	{
	    private readonly IRepository<Company> _companyRepository;

        public CompanyService(IRepository<Company> companyRepository, IUnitOfWork unitOfWork) : base(companyRepository, unitOfWork)
        {
            _companyRepository = companyRepository;

        }

	    public void UpdateCompany(Company company)
	    {
	        company.ID = 3;
	        Update(company);
	    }
    }
}