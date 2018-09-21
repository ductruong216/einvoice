using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Implementation;
using EInvoice.Data.Infrastructure.Interface;

namespace EInvoice.Data.Repositories
{
	public interface IUserRepository : IRepository<User>
	{

	}
	public class UserRepository : BaseRepository<User>, IUserRepository
	{
		public UserRepository(IDbFactory dbFactory) : base(dbFactory)
		{

		}
	}
}
