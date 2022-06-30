using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCategoryToLayout
    {
        public int CategoryId { get; set; }
        public int StoreId { get; set; }
        public int LayoutId { get; set; }
    }
}
