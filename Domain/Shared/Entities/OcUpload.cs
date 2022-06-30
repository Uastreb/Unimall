using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcUpload
    {
        public int UploadId { get; set; }
        public string Name { get; set; }
        public string Filename { get; set; }
        public string Code { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
