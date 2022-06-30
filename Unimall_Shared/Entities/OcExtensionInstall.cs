using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcExtensionInstall
    {
        public int ExtensionInstallId { get; set; }
        public int ExtensionDownloadId { get; set; }
        public string Filename { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
