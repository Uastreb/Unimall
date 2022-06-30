using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcUserGroup
    {
        public int UserGroupId { get; set; }
        public string Name { get; set; }
        public string Permission { get; set; }
    }
}
