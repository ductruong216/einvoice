using System.Collections.Generic;
using EInvoice.Data.Data;

namespace EInvoice.Web.Models
{
	public class NewInvoiceViewModel
	{
		public Invoice Invoice { get; set; }
		public EInvoice.Data.Data.Customer Customer { get; set; }
	}
}