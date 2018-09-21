using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Repositories;

namespace EInvoice.Service
{
	public interface IUserService : IBaseService<User>
	{
	}

	public class UserService : BaseService<User>, IUserService
	{
		public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork) : base(userRepository, unitOfWork)
		{
		}
	}
}