using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcStockStatus
    {
        public int StockStatusId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
