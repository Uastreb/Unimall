using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcInformationDescription
    {
        public int InformationId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
    }
}
