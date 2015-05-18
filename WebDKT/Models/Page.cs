using System;
using System.Collections.Generic;

namespace WebDKT.Models
{
    public partial class Page
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public string SeoUrl { get; set; }
        public string Content { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public string Layout { get; set; }
    }
}
