using System.ComponentModel.DataAnnotations;

namespace EInvoice.Web.Models
{
	public class CompanyViewModel
	{
		public int ID { get; set; }

		[Required(ErrorMessage = "Tax Code is required")]
		[Range(0, long.MaxValue, ErrorMessage = "Please enter valid integer Number"),]
		public string TaxCode { get; set; }

		[Required(ErrorMessage = "Company Name is required")]
		public string Name { get; set; }

	    [Required(ErrorMessage = "Company Name is required")]
        public string Address { get; set; }

		public string Phone { get; set; }
		public string Fax { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Email is invalid")]
		public string Email { get; set; }

		[RegularExpression("^(http:\\/\\/www\\.|https:\\/\\/www\\.|http:\\/\\/|https:\\/\\/)?" +
						   "[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,5}(:[0-9]{1,5})?(\\/.*)?$",
							ErrorMessage = "Website is invalid")]
		public string Website { get; set; }

		public string LegalPresenter { get; set; }

		[Range(0, long.MaxValue, ErrorMessage = "Please enter valid integer Number"),]
		public string BankAccountID { get; set; }

		public string AccountHolder { get; set; }
		public string BankName { get; set; }
		public string Agency { get; set; }
		public long? AccountID { get; set; }
		public string Note { get; set; }
		public int? SignatureID { get; set; }

		public virtual BankAccountViewModel BankAccount { get; set; }
		public virtual DigitalSignatureViewModel DigitalSignature { get; set; }
		public virtual CustomerViewModel Customers { get; set; }
	}
}