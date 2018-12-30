using System.Collections.Generic;

namespace EInvoice.Web.Models
{
    public class RoleViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }

       
        public virtual ICollection<UserViewModel> Users { get; set; }
    }
}