using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcGoogleshoppingProductStatus
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public string ProductVariationId { get; set; }
        public string DestinationStatuses { get; set; }
        public string DataQualityIssues { get; set; }
        public string ItemLevelIssues { get; set; }
        public int GoogleExpirationDate { get; set; }
    }
}
