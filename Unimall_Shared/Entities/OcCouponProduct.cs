﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCouponProduct
    {
        public int CouponProductId { get; set; }
        public int CouponId { get; set; }
        public int ProductId { get; set; }
    }
}
