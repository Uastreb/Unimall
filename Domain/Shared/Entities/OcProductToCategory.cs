using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcProductToCategory
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int MainCategory { get; set; }
    }
}
