using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcFilter
    {
        public int FilterId { get; set; }
        public int FilterGroupId { get; set; }
        public int SortOrder { get; set; }
    }
}
