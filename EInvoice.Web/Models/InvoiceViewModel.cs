using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EInvoice.Web.Models
{
	public partial class InvoiceViewModel
	{
		public long ID { get; set; }
		public long CompanyId { get; set; }
		public string Pattern { get; set; }
		public string Series { get; set; }
		public int No { get; set; }
		public string SecureCode { get; set; }
		public long? CustomerId { get; set; }
		public int PaymentTypeID { get; set; }
		public string Note { get; set; }
		public long ProductID { get; set; }
		public decimal Tax { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int UnitID { get; set; }
		public int Quantity { get; set; }
		public decimal VAT { get; set; }
		public decimal? VATCost { get; set; }
		public decimal? Discount { get; set; }
		public decimal? TotalServiceCost { get; set; }
		public decimal? TotalPaymentCost { get; set; }
		public string InWord { get; set; }
		public long? TypeID { get; set; }
		public int CreatorID { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? ModifyDate { get; set; }
		public string ModifyBy { get; set; }
		public string Status { get; set; }

		public virtual CompanyViewModel Company { get; set; }
		public virtual CompanyViewModel Company1 { get; set; }
		public virtual EmployeeViewModel Employee { get; set; }
		public virtual InvoiceTypeViewModel InvoiceType { get; set; }
		public virtual PaymentViewModel Payment { get; set; }
		public virtual ProductViewModel Product { get; set; }
		public virtual CustomerViewModel Customer { get; set; }
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
}