using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int Id { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
