using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOptionValueDescription
    {
        public int OptionValueId { get; set; }
        public int LanguageId { get; set; }
        public int OptionId { get; set; }
        public string Name { get; set; }
    }
}
