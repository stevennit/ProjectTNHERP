using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Entities
{
    public class OrderSellDetailAndProductionDetail 
    {
        public int Id { get; set; }
        public int IdOrderSellDetail { get; set; }
        public OrderSellDetail OrderSellDetail { get; set; }
        public int IdProductionDetail { get; set; }
        public ProductionDetail ProductionDetail { get; set; }
    }
}
