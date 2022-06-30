using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcApiSession
    {
        public int ApiSessionId { get; set; }
        public int ApiId { get; set; }
        public string SessionId { get; set; }
        public string Ip { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
