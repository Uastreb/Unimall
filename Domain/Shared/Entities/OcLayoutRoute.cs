﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcLayoutRoute
    {
        public int LayoutRouteId { get; set; }
        public int LayoutId { get; set; }
        public int StoreId { get; set; }
        public string Route { get; set; }
    }
}
