using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcReturn
    {
        public int ReturnId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Product { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public bool Opened { get; set; }
        public int ReturnReasonId { get; set; }
        public int ReturnActionId { get; set; }
        public int ReturnStatusId { get; set; }
        public string Comment { get; set; }
        public DateTime DateOrdered { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
