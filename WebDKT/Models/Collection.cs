using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class Collection
    {
        public Collection()
        {
            this.ThemeColletions = new List<ThemeColletion>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public virtual ICollection<ThemeColletion> ThemeColletions { get; set; }
    }
}
