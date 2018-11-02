using System.Collections.Generic;

namespace EInvoice.Web.Models
{
	public class SerialViewModel
	{
		public int ID { get; set; }
		public string Name { get; set; }

		public virtual ICollection<PatternViewModel> Patterns { get; set; }
	}
}