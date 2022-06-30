using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcTheme
    {
        public int ThemeId { get; set; }
        public int StoreId { get; set; }
        public string Theme { get; set; }
        public string Route { get; set; }
        public string Code { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
