using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class Feature
    {
        public Feature()
        {
            this.ThemeFeatures = new List<ThemeFeature>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public virtual ICollection<ThemeFeature> ThemeFeatures { get; set; }
    }
}
