using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcStore
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Ssl { get; set; }
    }
}
