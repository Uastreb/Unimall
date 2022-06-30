using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcFilterGroupDescription
    {
        public int FilterGroupId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
