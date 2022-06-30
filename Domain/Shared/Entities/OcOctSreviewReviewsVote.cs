using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctSreviewReviewsVote
    {
        public int OctSreviewReviewId { get; set; }
        public int OctSreviewSubjectId { get; set; }
        public int Rating { get; set; }
    }
}
