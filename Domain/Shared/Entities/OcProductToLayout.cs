using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcProductToLayout
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int LayoutId { get; set; }
    }
}
