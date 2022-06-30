using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcLayoutModule
    {
        public int LayoutModuleId { get; set; }
        public int LayoutId { get; set; }
        public string Code { get; set; }
        public string Position { get; set; }
        public int SortOrder { get; set; }
    }
}
