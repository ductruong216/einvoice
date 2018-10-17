using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;

namespace EInvoice.Service
{
	public class UserService : BaseService<User>, IUserService
	{
		public UserService(IRepository<User> userRepository, IUnitOfWork unitOfWork) : base(userRepository, unitOfWork)
		{
		}
	}
}