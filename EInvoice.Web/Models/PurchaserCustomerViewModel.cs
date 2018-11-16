using System.Collections.Generic;

namespace EInvoice.Web.Models
{
	public class PurchaserCustomerViewModel
	{
		public long ID { get; set; }
		public string Code { get; set; }
		public long? TaxCode { get; set; }
		public string EnterpriseName { get; set; }
		public string Purchaser { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public string LegalPresenter { get; set; }

		public virtual ICollection<InvoiceViewModel> Invoices { get; set; }
	}
}