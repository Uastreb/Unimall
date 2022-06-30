using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOrderStatus
    {
        public int OrderStatusId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
