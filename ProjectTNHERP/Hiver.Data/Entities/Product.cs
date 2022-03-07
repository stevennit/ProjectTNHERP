using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Product : HiverTableFull
    {
        public string Symbol { get; set; }
        public Double Width { get; set; }
        public Double Height { get; set; }
        public string Detail { get; set; }
        public int? ViewCount { set; get; }

        public Status Status { get; set; }

        public List<ProductAndProductCategory> ProductAndProductCategories { get; set; }
        public List<OrderSellDetail> OrderSellDetails { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}