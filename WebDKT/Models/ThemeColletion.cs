using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class ThemeColletion
    {
        public int Id { get; set; }
        public int ThemeId { get; set; }
        public int CollectionId { get; set; }
        public virtual Collection Collection { get; set; }
        public virtual ThemesStore ThemesStore { get; set; }
    }
}
