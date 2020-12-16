using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class ProductionDetail
    {
        public int Id { get; set; }
        public int QtyComplate { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime EndWork { get; set; }
        public decimal PercentComplete { get; set; }
        public bool Summary { get; set; }
        public bool Expanded { get; set; }

        public string UserUsing { get; set; }

        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }

        public List<OrderByDetailAndProductionDetail> OrderByDetailAndProductionDetails { get; set; }

        public List<OrderSellDetailAndProductionDetail> OrderSellDetailAndProductionDetails { get; set; }

        public int IdProduction { get; set; }
        public Production Production { get; set; }

        public List<KnifeMoldUsing> KnifeMoldUsings { get; set; }
    }
}