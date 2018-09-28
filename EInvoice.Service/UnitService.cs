using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Repositories;

namespace EInvoice.Service
{
	public interface IUnitService : IBaseService<Unit>
	{

	}
	public class UnitService : BaseService<Unit>, IUnitService
	{
		public UnitService(IUnitRepository unitRepository, IUnitOfWork unitOfWork) : base(unitRepository, unitOfWork)
		{

		}
	}
}
