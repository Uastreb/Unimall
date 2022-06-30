using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctMegamenu
    {
        public int MegamenuId { get; set; }
        public string Image { get; set; }
        public DateTime DateAdded { get; set; }
        public int ItemType { get; set; }
        public int SortOrder { get; set; }
        public bool? Status { get; set; }
        public int ImgWidth { get; set; }
        public int ImgHeight { get; set; }
        public int LimitItem { get; set; }
        public bool? ShowImg { get; set; }
        public int DisplayType { get; set; }
        public bool SubCategories { get; set; }
        public bool OpenLinkType { get; set; }
    }
}
