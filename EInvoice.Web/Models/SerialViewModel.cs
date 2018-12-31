using System;
using System.Collections.Generic;

namespace EInvoice.Web.Models
{
	public class SerialViewModel
	{	 
        public int ID { get; set; }
        public string Name { get; set; }
        public int PatternId { get; set; }
        public int? FromNo_ { get; set; }
        public int? ToNo_ { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual ICollection<InvoiceViewModel> Invoices { get; set; }
        public virtual PatternViewModel Pattern { get; set; }
	}
}