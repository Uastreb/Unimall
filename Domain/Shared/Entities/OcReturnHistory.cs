using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcReturnHistory
    {
        public int ReturnHistoryId { get; set; }
        public int ReturnId { get; set; }
        public int ReturnStatusId { get; set; }
        public bool Notify { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
