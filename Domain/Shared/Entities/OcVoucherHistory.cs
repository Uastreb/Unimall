using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcVoucherHistory
    {
        public int VoucherHistoryId { get; set; }
        public int VoucherId { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
