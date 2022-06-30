using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOrderSimpleField
    {
        public int OrderId { get; set; }
        public string Metadata { get; set; }
        public string PaymentField20 { get; set; }
        public string ShippingField20 { get; set; }
        public string PaymentField21 { get; set; }
        public string ShippingField21 { get; set; }
        public string PaymentField22 { get; set; }
        public string ShippingField22 { get; set; }
    }
}
