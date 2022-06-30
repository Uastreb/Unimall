using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCustomerGroup
    {
        public int CustomerGroupId { get; set; }
        public int Approval { get; set; }
        public int SortOrder { get; set; }
    }
}
