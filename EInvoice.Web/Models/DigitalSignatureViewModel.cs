using System;

namespace EInvoice.Web.Models
{
    public class DigitalSignatureViewModel
    {
        public int ID { get; set; }
        public string No { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ProviderName { get; set; }

        public virtual CompanyViewModel Companies { get; set; }
    }
}