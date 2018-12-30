namespace EInvoice.Web.Models
{
    public partial class BankAccountViewModel
    {
        public long ID { get; set; }
        public string AccountHolder { get; set; }
        public string NameOfBank { get; set; }
        public string Address { get; set; }
        public string Agency { get; set; }

        public virtual CompanyViewModel Companies { get; set; }
        public virtual CustomerViewModel Customers { get; set; }
    }
}