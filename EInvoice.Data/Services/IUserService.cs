using Data.Utilities.Enumeration;
using EInvoice.Data.Data;

namespace EInvoice.Data.Services
{
	public interface IUserService : IBaseService<User>
	{
		Enumerations.LoginStatus CheckLogin(string userName, string password);
		User GetCustomerByName(string userName);
	    bool CheckPassword(string pasword);
	}
}