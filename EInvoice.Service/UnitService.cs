using System.Collections.Generic;
using System.Linq;
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

		public void DeleteUnit(int id)
		{
			var unit = GetSingleById(id);
			unit.isDel = true;
			Update(unit);
		}

		public IList<Unit> GetUnits()
		{
			return GetAll().Where(x => x.isDel == false).ToList();
		}
	}
}