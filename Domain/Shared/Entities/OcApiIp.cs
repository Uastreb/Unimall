﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcApiIp
    {
        public int ApiIpId { get; set; }
        public int ApiId { get; set; }
        public string Ip { get; set; }
    }
}
