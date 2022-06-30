using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcApi
    {
        public int ApiId { get; set; }
        public string Username { get; set; }
        public string Key { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
