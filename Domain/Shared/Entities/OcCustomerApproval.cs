using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCustomerApproval
    {
        public int CustomerApprovalId { get; set; }
        public int CustomerId { get; set; }
        public string Type { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
