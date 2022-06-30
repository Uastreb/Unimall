using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcReview
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public string Reply { get; set; }
        public int Rating { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
