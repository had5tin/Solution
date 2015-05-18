using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class ThemeFeature
    {
        public int Id { get; set; }
        public int ThemeId { get; set; }
        public int FeatureId { get; set; }
        public virtual Feature Feature { get; set; }
        public virtual ThemesStore ThemesStore { get; set; }
    }
}
