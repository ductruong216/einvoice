using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using EInvoice.Data.Data;

namespace EInvoice.Web.Models
{
	public partial class ProductViewModel
	{
		public long ID { get; set; }

		[Required(ErrorMessage = "Customer Code is required")]
		[StringLength(20, ErrorMessage = "Must be under 20 characters")]

		//[Remote("IsProductCodeUniq", "Category", HttpMethod = "POST", ErrorMessage = "Product Code is Exist")]
		public string Code { get; set; }

		[Required(ErrorMessage = "Customer Code is required")]
		[StringLength(100, ErrorMessage = "Must be under 100 characters")]
		public string Name { get; set; }
		public string Description { get; set; }

		[Required(ErrorMessage = "Price is required")]
		[Range(0, double.MaxValue, ErrorMessage = "Price must better than 0"),]
		public decimal Price { get; set; }

		[Required(ErrorMessage = "Tax is required")]
		public decimal Tax { get; set; }
		public int? DisplayOrder { get; set; }
		public int? UnitID { get; set; }
		public int? CategoryID { get; set; }
		public int? Warranty { get; set; }
		public decimal? Discount { get; set; }

		public virtual UnitViewModel Unit { get; set; }

		public virtual ICollection<InvoiceViewModel> Invoices { get; set; }

	}

	public partial class ProductViewModel
	{
		public string UnitName
		{
			get => Unit.Name;
		}
	}
}