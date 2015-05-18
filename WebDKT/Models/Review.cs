using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class Review
    {
        public int Id { get; set; }
        public int ThemeId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Review1 { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
