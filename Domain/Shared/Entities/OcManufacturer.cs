using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcManufacturer
    {
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
    }
}
