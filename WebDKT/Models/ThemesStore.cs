using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class ThemesStore
    {
        public ThemesStore()
        {
            this.ThemeColletions = new List<ThemeColletion>();
            this.ThemeFeatures = new List<ThemeFeature>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SeoUrl { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public string Image { get; set; }
        public string ImagePhone { get; set; }
        public string Demo { get; set; }
        public int Setting { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public virtual ICollection<ThemeColletion> ThemeColletions { get; set; }
        public virtual ICollection<ThemeFeature> ThemeFeatures { get; set; }
    }
}
