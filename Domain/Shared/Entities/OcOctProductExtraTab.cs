using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctProductExtraTab
    {
        public int ProductId { get; set; }
        public int ExtraTabId { get; set; }
        public int LanguageId { get; set; }
        public string Text { get; set; }
    }
}
