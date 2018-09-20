namespace EInvoice.Data.Infrastructure.Interface
{
	public interface IUnitOfWork
	{
		void Commit();
	}
}