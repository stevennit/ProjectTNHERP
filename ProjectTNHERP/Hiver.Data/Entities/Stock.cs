using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }

        public int? IdStockCategory { set; get; }
        public StockCategory StockCategory { set; get; }
        public List<OrderByDetail> OrderByStocks { set; get; }
        public List<StockImage> StockImages { set; get; }
    }
}