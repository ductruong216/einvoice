using System;
using System.Linq;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;


namespace EInvoice.Repository
{

	public static class ItemRepository
	{
		public static void RemoveAllItem(this IRepository<Item> repository, long invoiceId)
		{
			try
			{
				var db = new InvoiceEntities();
				db.Items.RemoveRange(db.Items.Where(x => x.InvoiceId == invoiceId));
				db.SaveChanges();
			}
			catch (Exception e)
			{
				throw e;
			}

		}
	}

}