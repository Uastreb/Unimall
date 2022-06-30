using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCategoryPath
    {
        public int CategoryId { get; set; }
        public int PathId { get; set; }
        public int Level { get; set; }
    }
}
