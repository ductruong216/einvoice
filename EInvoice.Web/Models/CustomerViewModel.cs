namespace EInvoice.Web.Models
{
	public class CustomerViewModel
	{
		public int CustomerID { get; set; }
		public string CustomerCode { get; set; }
		public int CompanyID { get; set; }
		public string Purchaser { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public int AccountID { get; set; }
		public int EmailID { get; set; }
		public string Note { get; set; }
	}
}