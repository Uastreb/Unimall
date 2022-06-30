using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctPopupFoundCheaper
    {
        public int RequestId { get; set; }
        public string Info { get; set; }
        public bool Processed { get; set; }
        public string Note { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
