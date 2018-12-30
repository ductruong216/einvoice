using System;

namespace EInvoice.Web.Models
{
    public class UserViewModel
    {
        public long ID { get; set; }
        public long? RoleId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime? BirthDay { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string Position { get; set; }

        public virtual RoleViewModel Role { get; set; }
    }
}