using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Product : HiverTableFull
    {
        // Mã Thành Phẩm - Nguyên Liệu
        public string Code { get; set; }
        public Double Width { get; set; }
        public Double Height { get; set; }
        public string Detail { get; set; }
        public string Color { get; set; }
        public int QtyProduction { get; set; }
        public int QtyNG { get; set; }
        public int? ViewCount { set; get; }

        public bool Status { get; set; }

        public List<ProductAndProductCategory> ProductAndProductCategories { get; set; }
        public List<Production> Productions { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}