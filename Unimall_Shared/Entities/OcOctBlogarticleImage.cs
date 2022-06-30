using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctBlogarticleImage
    {
        public int ArticleImageId { get; set; }
        public int BlogarticleId { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
    }
}
