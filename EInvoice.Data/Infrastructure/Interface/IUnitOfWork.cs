namespace EInvoice.Data.Infrastructure.Interface
{
	public interface IUnitOfWork
	{
		void SaveChanges();
	}
}