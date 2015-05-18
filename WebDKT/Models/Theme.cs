using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class Theme
    {
        public string ThemeType { get; set; }
        public string ThemeName { get; set; }
        public bool StoreTheme { get; set; }
        public System.DateTime Modified { get; set; }
        public int Id { get; set; }
    }
}
