using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcSession
    {
        public string SessionId { get; set; }
        public string Data { get; set; }
        public DateTime Expire { get; set; }
    }
}
