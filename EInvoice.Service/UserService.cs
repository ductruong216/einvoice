using Data.Utilities.Enumeration;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;
using EInvoice.Repository;

namespace EInvoice.Service
{
	//[PermissionLogin]
	public class UserService : BaseService<User>, IUserService
	{
		private readonly IRepository<User> _userRepository;

		public UserService(IRepository<User> userRepository, IUnitOfWork unitOfWork) : base(userRepository, unitOfWork)
		{
			_userRepository = userRepository;
		}

		public Enumerations.LoginStatus CheckLogin(string userName, string password)
		{
			var user = _userRepository.GetCustomerByName(userName);
			if (user == null)
			{
				return Enumerations.LoginStatus.WrongUserName;
			}
			else
			{
				if (!user.PasswordHash.Equals(password))
				{
					return Enumerations.LoginStatus.WrongPassword;
				}
				else
				{
					return Enumerations.LoginStatus.Succsess;
				}
			}
		}

		public User GetCustomerByName(string userName)
		{
			return _userRepository.GetCustomerByName(userName);
		}
	}
}