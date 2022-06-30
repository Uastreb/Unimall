using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcBanner
    {
        public int BannerId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
