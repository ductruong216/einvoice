using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;

namespace EInvoice.Service
{
	public class ItemService : BaseService<Item>, IItemService
	{
		public ItemService(IRepository<Item> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
		{

		}
	}
}