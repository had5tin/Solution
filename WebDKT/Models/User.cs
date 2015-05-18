using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class User
    {
        public User()
        {
            this.UserRoles = new List<UserRole>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Email { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
        public Nullable<int> LogNum { get; set; }
        public string Description { get; set; }
        public bool ResetIpPermission { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
