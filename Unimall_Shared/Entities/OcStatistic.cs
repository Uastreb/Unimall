using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcStatistic
    {
        public int StatisticsId { get; set; }
        public string Code { get; set; }
        public decimal Value { get; set; }
    }
}
