using System.Linq;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;

namespace EInvoice.Repository
{
	public static class UserRepository
	{
		public static User GetCustomerByName(this IRepository<User> repository, string userName)
		{
			return repository.DbSet.FirstOrDefault(_ => _.UserName == userName);
		}
	}
}