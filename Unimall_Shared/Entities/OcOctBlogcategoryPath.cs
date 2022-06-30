using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctBlogcategoryPath
    {
        public int BlogcategoryId { get; set; }
        public int BlogPathId { get; set; }
        public int Level { get; set; }
    }
}
