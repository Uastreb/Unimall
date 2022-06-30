using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcModule
    {
        public int ModuleId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Setting { get; set; }
    }
}
