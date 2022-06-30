using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcTaxRateToCustomerGroup
    {
        public int TaxRateId { get; set; }
        public int CustomerGroupId { get; set; }
    }
}
