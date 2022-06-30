using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctSreviewReview
    {
        public int OctSreviewReviewId { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public string AdminText { get; set; }
        public bool Status { get; set; }
        public int AvgRating { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
