using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcSeoUrl
    {
        public int SeoUrlId { get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
        public string Query { get; set; }
        public string Keyword { get; set; }
    }
}
