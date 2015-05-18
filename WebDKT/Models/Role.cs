using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class Role
    {
        public Role()
        {
            this.Permissions = new List<Permission>();
            this.Roles1 = new List<Role>();
            this.UserRoles = new List<UserRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> ParentId { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<Role> Roles1 { get; set; }
        public virtual Role Role1 { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
