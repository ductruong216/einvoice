namespace EInvoice.Web.Models
{
    public class AddInvoiceViewModel
    {
        public InvoiceViewModel Invoice { get; set; }
        public CustomerViewModel Customer { get; set; }
        public ItemViewModel Item { get; set; }
        public ProductViewModel Product { get; set; }
    }
}