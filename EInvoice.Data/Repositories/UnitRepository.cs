using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Implementation;
using EInvoice.Data.Infrastructure.Interface;

namespace EInvoice.Data.Repositories
{
	public interface IUnitRepository : IRepository<Unit>
	{
	}

	public class UnitRepository : BaseRepository<Unit>, IUnitRepository
	{
		public UnitRepository(IDbFactory dbFactory) : base(dbFactory)
		{
		}
	}
}