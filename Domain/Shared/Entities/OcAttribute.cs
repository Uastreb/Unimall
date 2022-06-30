using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcAttribute
    {
        public int AttributeId { get; set; }
        public int AttributeGroupId { get; set; }
        public int SortOrder { get; set; }
    }
}
