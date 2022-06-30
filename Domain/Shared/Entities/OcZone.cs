using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcZone
    {
        public int ZoneId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool? Status { get; set; }
    }
}
