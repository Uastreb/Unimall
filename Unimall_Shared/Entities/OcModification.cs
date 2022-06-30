using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcModification
    {
        public int ModificationId { get; set; }
        public int ExtensionInstallId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Author { get; set; }
        public string Version { get; set; }
        public string Link { get; set; }
        public string Xml { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
