using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class OrderSellDetail : HiverTableFull
    {
        public int Qty { get; set; }
        public DateTime DateDelivery { get; set; }

        public Status Status { get; set; }

        public List<OrderSellDetailAndProductionDetail> OrderSellDetailAndProductionDetails { get; set; }

        public int IdProduct { get; set; }
        public Product Product { get; set; }

        public int IdOrderSell { get; set; }
        public OrderSell OrderSell { get; set; }

    }
}