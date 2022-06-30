using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcExtension
    {
        public int ExtensionId { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
    }
}
