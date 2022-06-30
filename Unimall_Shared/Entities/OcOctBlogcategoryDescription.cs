using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctBlogcategoryDescription
    {
        public int BlogcategoryId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public string MetaH1 { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
    }
}
