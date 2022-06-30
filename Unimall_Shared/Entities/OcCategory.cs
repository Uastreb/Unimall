using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCategory
    {
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public string OctImage { get; set; }
        public int ParentId { get; set; }
        public bool Top { get; set; }
        public int Column { get; set; }
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        public string PageGroupLinks { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
