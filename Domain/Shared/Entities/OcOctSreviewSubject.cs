using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctSreviewSubject
    {
        public int OctSreviewSubjectId { get; set; }
        public int SortOrder { get; set; }
        public int SubjectRatingCount1 { get; set; }
        public int SubjectRatingCount2 { get; set; }
        public int SubjectRatingCount3 { get; set; }
        public int SubjectRatingCount4 { get; set; }
        public int SubjectRatingCount5 { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
