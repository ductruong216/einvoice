using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EInvoice.Web.Models
{
	public class UnitViewModel
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public virtual ICollection<ProductViewModel> Products { get; set; }
	}
}