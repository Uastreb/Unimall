using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCustomerHistory
    {
        public int CustomerHistoryId { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
