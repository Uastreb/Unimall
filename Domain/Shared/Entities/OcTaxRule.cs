using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcTaxRule
    {
        public int TaxRuleId { get; set; }
        public int TaxClassId { get; set; }
        public int TaxRateId { get; set; }
        public string Based { get; set; }
        public int Priority { get; set; }
    }
}
