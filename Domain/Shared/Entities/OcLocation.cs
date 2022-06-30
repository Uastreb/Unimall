using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcLocation
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Geocode { get; set; }
        public string Image { get; set; }
        public string Open { get; set; }
        public string Comment { get; set; }
    }
}
