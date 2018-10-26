using System;
using System.Collections.Generic;

namespace EInvoice.Web.Models
{
	public partial class InvoiceViewModel
	{
		public long ID { get; set; }
		public long CompanyId { get; set; }
		public int FormId { get; set; }
		public string Series { get; set; }
		public int No { get; set; }
		public string SecureCode { get; set; }
		public long? CustomerId { get; set; }
		public int PaymentTypeID { get; set; }
		public string Note { get; set; }
		public decimal Tax { get; set; }
		public string Name { get; set; }
		public decimal? TaxAmount { get; set; }
		public decimal? SubTotalAmount { get; set; }
		public decimal? GrandTotalAmount { get; set; }
		public string InWord { get; set; }
		public long? TypeID { get; set; }
		public int CreatorID { get; set; }
		public System.DateTime CreatedDate { get; set; }
		public DateTime? ModifyDate { get; set; }
		public string ModifyBy { get; set; }
		public string Status { get; set; }
		public virtual CompanyViewModel Company { get; set; }

		public virtual CustomerViewModel Customer { get; set; }
		public virtual EmployeeViewModel Employee { get; set; }
	//	public virtual FormViewModel Form { get; set; }
		public virtual InvoiceTypeViewModel InvoiceType { get; set; }
		public virtual PaymentMethodViewModel PaymentMethod { get; set; }
		public virtual ICollection<ItemViewModel> Items { get; set; }
	}

	public partial class InvoiceViewModel
	{
		public string CompanyName => Company.Name;
		public string CompanyTaxCode => Company.TaxCode;
		public string CompanyAddress => Company.Address;
		public string CompanyPhone => Company.Phone;
		public string CompanyFax => Company.Fax;
		public string CompanyEmail => Company.Email;
		public string CompanyWebsite => Company.Website;
		public string CompanyLegalPresent => Company.LegalPresenter;
		public string CompanyBankAccountID => Company.BankAccountID;
		public string CompanyAccountHolder => Company.AccountHolder;
		public string CompanyBankName => Company.BankName;
		public string CompanyAgency => Company.Agency;
		public long? CompanyAccountID => Company.AccountID;
		public string CompanyNote => Company.Note;
		
		// Signature
	 
	}
	public partial class InvoiceViewModel
	{
		public string CustomerName => Customer.Name;

		public string CustomerCode => Customer.Code;

		public string Purchaser => Customer.Purchaser;

		public long? CustomerTaxCode => Customer.TaxCode;

		public string CustomerAddress => Customer.Address;

		public string CustomerPhone => Customer.Phone;

		public string CustomerFax => Customer.Fax;

		public string CustomerEmail => Customer.Email;

		public long? CustomerBankAccountID => Customer.BankAccountID;

		public string CustomerAccountHolder => Customer.AccountHolder;

		public string CustomerBankName => Customer.BankName;

		public string CustomerAgency => Customer.Agency;

		public string CustomerNote => Customer.Note;
	}

	public partial class InvoiceViewModel
	{
		
	}
}