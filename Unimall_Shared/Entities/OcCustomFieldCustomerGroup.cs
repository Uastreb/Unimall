using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCustomFieldCustomerGroup
    {
        public int CustomFieldId { get; set; }
        public int CustomerGroupId { get; set; }
        public bool Required { get; set; }
    }
}
