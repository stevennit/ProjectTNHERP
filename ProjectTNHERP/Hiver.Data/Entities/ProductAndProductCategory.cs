using System;

namespace Hiver.Data.Entities
{
    public class ProductAndProductCategory
    {
        public Guid? IdProduct { get; set; }
        public Product Product { get; set; }
        public Guid? IdProductCategory { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}