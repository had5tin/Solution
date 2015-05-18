using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class Resource
    {
        public Resource()
        {
            this.Permissions = new List<Permission>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> ParentId { get; set; }
        public System.DateTime Modified { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
