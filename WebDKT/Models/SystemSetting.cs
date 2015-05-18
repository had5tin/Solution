using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class SystemSetting
    {
        public string setting_key { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<int> Type { get; set; }
        public string Value { get; set; }
        public string Options { get; set; }
        public Nullable<bool> IsRequired { get; set; }
        public int Id { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
    }
}
