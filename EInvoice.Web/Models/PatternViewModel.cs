using System.Collections.Generic;

namespace EInvoice.Web.Models
{
	public class PatternViewModel
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Content { get; set; }
		public int? SerialId { get; set; }

		public virtual ICollection<InvoiceViewModel> Invoices { get; set; }
		public virtual SerialViewModel Serial { get; set; }
	}
}