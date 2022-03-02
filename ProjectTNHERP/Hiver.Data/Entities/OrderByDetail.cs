using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class OrderByDetail : HiverTableFull
    {
        public int Qty { get; set; }
        public Status Status { get; set; }

        public int IdStock { get; set; }
        public Stock Stock { get; set; }
        public int IdOrderBy { get; set; }
        public OrderBy OrderBy { get; set; }

        public List<OrderByDetailAndProductionDetail> OrderByDetailAndProductionDetails { get; set; }
    }
}