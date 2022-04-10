using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class OrderSell : HiverTableFull
    {
        public string Detail { get; set; }

        public Status Status { get; set; }

        public int IdCustomer { get; set; }
        public Partner Customer { get; set; }

        public List<OrderSellDetail> OrderSellDetails { get; set; }

    }
}