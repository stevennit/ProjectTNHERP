using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public Double Width { get; set; }
        public Double Height { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public int ViewCount { set; get; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }

        public List<ProductAndProductCategory> ProductAndProductCategories { get; set; }
        public List<OrderSellDetail> OrderSellDetails { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}