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
    
    public partial class Serial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Serial()
        {
            this.Invoices = new HashSet<Invoice>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int PatternId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual Pattern Pattern { get; set; }
    }
}
