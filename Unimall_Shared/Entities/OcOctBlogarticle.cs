using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctBlogarticle
    {
        public int BlogarticleId { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        public int Viewed { get; set; }
        public DateTime DateAvailable { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
