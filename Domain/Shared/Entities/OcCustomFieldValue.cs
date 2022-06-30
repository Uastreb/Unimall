using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCustomFieldValue
    {
        public int CustomFieldValueId { get; set; }
        public int CustomFieldId { get; set; }
        public int SortOrder { get; set; }
    }
}
