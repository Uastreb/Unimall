using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcShippingCourier
    {
        public int ShippingCourierId { get; set; }
        public string ShippingCourierCode { get; set; }
        public string ShippingCourierName { get; set; }
    }
}
