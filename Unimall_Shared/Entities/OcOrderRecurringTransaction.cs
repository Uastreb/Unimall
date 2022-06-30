using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOrderRecurringTransaction
    {
        public int OrderRecurringTransactionId { get; set; }
        public int OrderRecurringId { get; set; }
        public string Reference { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
