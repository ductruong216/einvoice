namespace EInvoice.Web.Models
{
	public class ProductViewModel
	{
		public int ProductID { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int UnitID { get; set; }
		public decimal Tax { get; set; }
		public string Description { get; set; }
	}
}