using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOrderShipment
    {
        public int OrderShipmentId { get; set; }
        public int OrderId { get; set; }
        public DateTime DateAdded { get; set; }
        public string ShippingCourierId { get; set; }
        public string TrackingNumber { get; set; }
    }
}
