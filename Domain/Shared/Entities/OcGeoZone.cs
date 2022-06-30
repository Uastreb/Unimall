using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcGeoZone
    {
        public int GeoZoneId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
