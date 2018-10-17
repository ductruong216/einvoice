using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;

namespace EInvoice.Service
{
	public class UnitService : BaseService<Unit>, IUnitService
	{
		public UnitService(IRepository<Unit> unitRepository, IUnitOfWork unitOfWork) : base(unitRepository, unitOfWork)
		{
		}
	}
}