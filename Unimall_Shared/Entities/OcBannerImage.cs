using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcBannerImage
    {
        public int BannerImageId { get; set; }
        public int BannerId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
    }
}
