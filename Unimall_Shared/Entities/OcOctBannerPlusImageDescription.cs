using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctBannerPlusImageDescription
    {
        public int BannerImageId { get; set; }
        public int LanguageId { get; set; }
        public int BannerId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Button { get; set; }
        public string Description { get; set; }
    }
}
