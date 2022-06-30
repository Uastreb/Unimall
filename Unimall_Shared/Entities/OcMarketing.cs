using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcMarketing
    {
        public int MarketingId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int Clicks { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
