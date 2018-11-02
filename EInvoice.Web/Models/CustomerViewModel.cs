using System.ComponentModel.DataAnnotations;

namespace EInvoice.Web.Models
{
	public class CustomerViewModel
	{
		public long ID { get; set; }

		[Required(ErrorMessage = "Customer Code is required")]
		[StringLength(20, ErrorMessage = "Must be under 20 characters")]
		//[Remote("IsCustomerCodeUniq", "Category", HttpMethod = "POST", ErrorMessage = "Customer Code is Exist")]

		public string Code { get; set; }

		//[Remote("IsCustomerTaxCodeUniq", "Category", HttpMethod = "POST", ErrorMessage = "Tax Code is Exist")]
		public long? TaxCode { get; set; }

		public string Purchaser { get; set; }

		[Required(ErrorMessage = "Name is required")]
		[StringLength(50, ErrorMessage = "Must be under 50 characters")]
		public string Name { get; set; }

		public string Address { get; set; }

		[Range(0, long.MaxValue, ErrorMessage = "Please enter valid integer Number"),]
		public string Phone { get; set; }

		public string Fax { get; set; }

		[RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Email is invalid")]
		public string Email { get; set; }

		public string LegalPresenter { get; set; }
		public long? BankAccountID { get; set; }

		public string AccountHolder { get; set; }
		public string BankName { get; set; }
		public string Agency { get; set; }
		public string Note { get; set; }
		public bool isDel { get; set; }
		
		public virtual BankAccountViewModel BankAccount { get; set; }
		public virtual CompanyViewModel Company { get; set; }
	}
}