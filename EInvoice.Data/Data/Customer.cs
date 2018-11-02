//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EInvoice.Data.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Invoices = new HashSet<Invoice>();
        }
    
        public long ID { get; set; }
        public string Code { get; set; }
        public Nullable<long> TaxCode { get; set; }
        public string Name { get; set; }
        public string Purchaser { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string LegalPresenter { get; set; }
        public string AccountHolder { get; set; }
        public Nullable<long> BankAccountID { get; set; }
        public string BankName { get; set; }
        public string Agency { get; set; }
        public string Note { get; set; }
        public bool isDel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
