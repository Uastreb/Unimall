using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcDownloadDescription
    {
        public int DownloadId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
