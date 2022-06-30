using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcProductRecurring
    {
        public int ProductId { get; set; }
        public int RecurringId { get; set; }
        public int CustomerGroupId { get; set; }
    }
}
