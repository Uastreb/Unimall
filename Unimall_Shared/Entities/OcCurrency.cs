using System;
using System.Collections.Generic;

#nullable disable

namespace Shared.Entities
{
    public partial class OcCurrency
    {
        public int CurrencyId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string SymbolLeft { get; set; }
        public string SymbolRight { get; set; }
        public string DecimalPlace { get; set; }
        public double Value { get; set; }
        public bool Status { get; set; }
        public DateTime DateModified { get; set; }
    }
}
