﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOrderOption
    {
        public int OrderOptionId { get; set; }
        public int OrderId { get; set; }
        public int OrderProductId { get; set; }
        public int ProductOptionId { get; set; }
        public int ProductOptionValueId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
    }
}
