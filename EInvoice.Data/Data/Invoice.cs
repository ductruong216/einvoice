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
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.Items = new HashSet<Item>();
        }
    
        public long ID { get; set; }
        public int CompanyId { get; set; }
        public int PatternId { get; set; }
        public int SeriesId { get; set; }
        public int No { get; set; }
        public string SecureCode { get; set; }
        public long PurchaserCustomerID { get; set; }
        public long CustomerId { get; set; }
        public int PaymentTypeID { get; set; }
        public string Note { get; set; }
        public Nullable<int> Tax { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<decimal> SubTotalAmount { get; set; }
        public Nullable<decimal> GrandTotalAmount { get; set; }
        public string InWord { get; set; }
        public Nullable<long> CreatorID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public string Status { get; set; }
        public bool isDel { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Pattern Pattern { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual PurchaserCustomer PurchaserCustomer { get; set; }
        public virtual Serial Serial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
    }
}
