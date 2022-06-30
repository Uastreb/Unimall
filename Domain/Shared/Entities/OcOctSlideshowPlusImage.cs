using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctSlideshowPlusImage
    {
        public int SlideshowImageId { get; set; }
        public int SlideshowId { get; set; }
        public string Image { get; set; }
        public string BackgroundColor { get; set; }
        public string TitleColor { get; set; }
        public string TextColor { get; set; }
        public string ButtonColor { get; set; }
        public string ButtonBackground { get; set; }
        public string ButtonColorHover { get; set; }
        public string ButtonBackgroundHover { get; set; }
        public int SortOrder { get; set; }
    }
}
