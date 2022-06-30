﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcZoneToGeoZone
    {
        public int ZoneToGeoZoneId { get; set; }
        public int CountryId { get; set; }
        public int ZoneId { get; set; }
        public int GeoZoneId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
