using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctSubscribe
    {
        public int SubscribeId { get; set; }
        public string Email { get; set; }
        public string Ip { get; set; }
        public bool Approved { get; set; }
        public DateTime DateAdded { get; set; }
        public string Hash { get; set; }
    }
}
