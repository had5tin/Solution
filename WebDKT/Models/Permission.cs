using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class Permission
    {
        public int RoleId { get; set; }
        public int ResourceId { get; set; }
        public string Privilege { get; set; }
        public bool IsAllowed { get; set; }
        public int Id { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual Resource Resource { get; set; }
        public virtual Role Role { get; set; }
    }
}
