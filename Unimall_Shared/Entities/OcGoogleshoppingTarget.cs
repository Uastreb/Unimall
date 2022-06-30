using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcGoogleshoppingTarget
    {
        public int AdvertiseGoogleTargetId { get; set; }
        public int StoreId { get; set; }
        public string CampaignName { get; set; }
        public string Country { get; set; }
        public decimal Budget { get; set; }
        public string Feeds { get; set; }
        public string Status { get; set; }
        public DateTime? DateAdded { get; set; }
        public int Roas { get; set; }
    }
}
