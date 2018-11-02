using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;

namespace EInvoice.Service
{
	public class PatternService : BaseService<Pattern>, IPatternService
	{
		public PatternService(IRepository<Pattern> patternRepository, IUnitOfWork unitOfWork) : base(patternRepository,
			unitOfWork)
		{

		}
	}
}