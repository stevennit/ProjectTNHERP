using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class StockCategory : HiverTableFull
    {
        public string Image { get; set; }

        public Status Status { get; set; }

        public List<Stock> Stocks { get; set; }
    }
}