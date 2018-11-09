using System.ComponentModel.DataAnnotations;

namespace EInvoice.Web.Models
{
	public partial class ItemViewModel
	{
		public int ID { get; set; }
		public long? InvoiceId { get; set; }
		public long? ProductId { get; set; }
		public long? Quantity { get; set; }
		[DataType(DataType.Currency)] public decimal? Discount { get; set; }
		[DataType(DataType.Currency)] public decimal? TotalAmount { get; set; }
		public virtual ProductViewModel Product { get; set; }
		public virtual InvoiceViewModel Invoice { get; set; }

	}
	public partial class ItemViewModel
	{
		public string ProductName => Product.Name;
		public string ProductCode => Product.Code;
		public string Description => Product.Description;
		public decimal ProductPrice => Product.Price;
		public decimal ProductTax => Product.Tax;
		public string UnitName => Product.UnitName;
		public int? Warranty => Product.Warranty;
	}
}