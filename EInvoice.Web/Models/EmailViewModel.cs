using System.Collections.Generic;

namespace EInvoice.Web.Models
{
    public class EmailViewModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string EmailCC { get; set; }

        public virtual ICollection<CompanyViewModel> Companies { get; set; }
    }
}