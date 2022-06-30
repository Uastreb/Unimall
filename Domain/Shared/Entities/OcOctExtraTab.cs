using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctExtraTab
    {
        public int ExtraTabId { get; set; }
        public int SortOrder { get; set; }
        public bool? Status { get; set; }
    }
}
