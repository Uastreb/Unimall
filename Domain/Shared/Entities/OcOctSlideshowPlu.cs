using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctSlideshowPlu
    {
        public int SlideshowId { get; set; }
        public string Name { get; set; }
        public bool? StatusAdditionalBanners { get; set; }
        public bool? PositionBanners { get; set; }
        public bool Status { get; set; }
    }
}
