using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcDownload
    {
        public int DownloadId { get; set; }
        public string Filename { get; set; }
        public string Mask { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
