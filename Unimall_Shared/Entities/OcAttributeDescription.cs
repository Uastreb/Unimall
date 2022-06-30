using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcAttributeDescription
    {
        public int AttributeId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
