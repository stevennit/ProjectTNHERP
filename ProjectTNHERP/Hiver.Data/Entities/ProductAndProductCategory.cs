using System;

namespace Hiver.Data.Entities
{
    public class ProductAndProductCategory
    {
        public int IdProduct { get; set; }
        public Product Product { get; set; }
        public int IdProductCategory { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}