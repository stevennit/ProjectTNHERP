using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Stock : HiverTableFull
    {
        public string Symbol { get; set; }
        public string Detail { get; set; }

        // Mã Thành Phẩm - Nguyên Liệu
        public string Code { get; set; }

        public Status Status { get; set; }

        public Guid? IdStockCategory { set; get; }
        public StockCategory StockCategory { set; get; }
        public List<ProductionStock> ProductionStocks { set; get; }
        public List<StockImage> StockImages { set; get; }
    }
}