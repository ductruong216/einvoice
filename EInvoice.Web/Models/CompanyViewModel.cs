namespace EInvoice.Web.Models
{
	public class CompanyViewModel
	{
		public long TaxCode { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public int EmailID { get; set; }

		public string Website { get; set; }
		public string LegalPresenter { get; set; }
		public long? BankAccountID { get; set; }
		public string AccountHolder { get; set; }
		public string BankName { get; set; }
		public string Agency { get; set; }

		public long? AccountID { get; set; }
		public string Note { get; set; }
		public int? SignatureID { get; set; }

		public virtual BankAccountViewModel BankAccount { get; set; }
		public virtual DigitalSignatureViewModel DigitalSignature { get; set; }
		public virtual EmailViewModel Email { get; set; }
		public virtual CustomerViewModel Customers { get; set; }
	}
}