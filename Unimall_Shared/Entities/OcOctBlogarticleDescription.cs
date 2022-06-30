﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcOctBlogarticleDescription
    {
        public int BlogarticleId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string ShotDescription { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
    }
}
