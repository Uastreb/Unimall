using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCustomerWishlist
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
