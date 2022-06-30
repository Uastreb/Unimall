using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCustomFieldDescription
    {
        public int CustomFieldId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
