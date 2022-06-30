using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcWeightClassDescription
    {
        public int WeightClassId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Unit { get; set; }
    }
}
