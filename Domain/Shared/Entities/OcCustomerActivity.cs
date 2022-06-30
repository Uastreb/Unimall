using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCustomerActivity
    {
        public int CustomerActivityId { get; set; }
        public int CustomerId { get; set; }
        public string Key { get; set; }
        public string Data { get; set; }
        public string Ip { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
