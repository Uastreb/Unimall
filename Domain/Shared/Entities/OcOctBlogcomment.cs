using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctBlogcomment
    {
        public int CommentId { get; set; }
        public int BlogarticleId { get; set; }
        public int CustomerId { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public string AdminText { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
