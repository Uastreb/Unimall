using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctBlogcategory
    {
        public int BlogcategoryId { get; set; }
        public string Image { get; set; }
        public int ParentId { get; set; }
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
