using System.Collections.Generic;
using EInvoice.Data.Data;

namespace EInvoice.Data.Services
{
	public interface IUnitService : IBaseService<Unit>
	{
		void DeleteUnit(int id);
		IList<Unit> GetUnits();
	}
}