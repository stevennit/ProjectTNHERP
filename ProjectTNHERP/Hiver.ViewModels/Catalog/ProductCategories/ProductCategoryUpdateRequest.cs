using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.ProductCategories
{
    public class ProductCategoryUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ImageMore { get; set; }

        public DateTime ModifyDate { get; set; } = DateTime.Now;
        public string ModifyBy { get; set; }
        public Status Status { get; set; }
    }
}
