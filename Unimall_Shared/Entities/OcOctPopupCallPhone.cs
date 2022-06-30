using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctPopupCallPhone
    {
        public int RequestId { get; set; }
        public string Info { get; set; }
        public bool Processed { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
