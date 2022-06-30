using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctBannerPlusImage
    {
        public int BannerImageId { get; set; }
        public int BannerId { get; set; }
        public string Image { get; set; }
        public string BackgroundColor { get; set; }
        public string TitleColor { get; set; }
        public string TextColor { get; set; }
        public string ButtonColor { get; set; }
        public string ButtonBackground { get; set; }
        public string ButtonBackgroundHover { get; set; }
        public string ButtonTextHover { get; set; }
        public int SortOrder { get; set; }
    }
}
