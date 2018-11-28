using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;

namespace EInvoice.Repository
{
	public static class SerialRepository
	{
		public static IEnumerable<Serial> GetSeriesByPattern(this IRepository<Serial> repository, int patternId)
		{
		return repository.GetAll().Where(x => x.PatternId == patternId);
		}
	}
}
