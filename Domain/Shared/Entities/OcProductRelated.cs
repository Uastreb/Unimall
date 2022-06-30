using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcProductRelated
    {
        public int ProductId { get; set; }
        public int RelatedId { get; set; }
    }
}
