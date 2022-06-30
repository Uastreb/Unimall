using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCustomFieldValueDescription
    {
        public int CustomFieldValueId { get; set; }
        public int LanguageId { get; set; }
        public int CustomFieldId { get; set; }
        public string Name { get; set; }
    }
}
