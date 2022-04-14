using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class OrderSell : HiverTableFull
    {
        // Mã đơn hàng
        public string Code { get; set; }
        public string Detail { get; set; }

        public bool Status { get; set; }

        public Guid? IdPartnerCategory { get; set; }

        public List<Production> Productions { get; set; }

    }
}