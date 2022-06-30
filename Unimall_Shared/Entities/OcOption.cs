using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOption
    {
        public int OptionId { get; set; }
        public string Type { get; set; }
        public int SortOrder { get; set; }
    }
}
