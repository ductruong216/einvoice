using System.Collections.Generic;
using EInvoice.Data.Data;

namespace EInvoice.Web.Models
{
	public class InvoiceTypeViewModel
	{
		public long ID { get; set; }
		public string Name { get; set; }

		public virtual ICollection<InvoiceViewModel> Invoices { get; set; }
	}
}