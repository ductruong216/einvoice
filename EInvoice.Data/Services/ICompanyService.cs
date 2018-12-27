using EInvoice.Data.Data;

namespace EInvoice.Data.Services
{
	public interface ICompanyService : IBaseService<Company>
	{
	    void UpdateCompany(Company company);
	}
}