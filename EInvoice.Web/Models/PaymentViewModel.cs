﻿using System.Collections.Generic;

namespace EInvoice.Web.Models
{
	public class PaymentViewModel
	{
		public int ID { get; set; }
		public string Name { get; set; }

		public virtual ICollection<InvoiceViewModel> Invoices { get; set; }
	}
}