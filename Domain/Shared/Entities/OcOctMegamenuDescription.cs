using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctMegamenuDescription
    {
        public int MegamenuId { get; set; }
        public int LanguageId { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string CustomHtml { get; set; }
    }
}
