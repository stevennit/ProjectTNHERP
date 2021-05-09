using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class OrderSellDetail
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public DateTime DateDelivery { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }

        public List<OrderSellDetailAndProductionDetail> OrderSellDetailAndProductionDetails { get; set; }

        public int IdProduct { get; set; }
        public Product Product { get; set; }

        public int IdOrderSell { get; set; }
        public OrderSell OrderSell { get; set; }

    }
}