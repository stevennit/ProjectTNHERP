using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.Products
{
    public class ProductVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public Double Width { get; set; }
        public Double Height { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
       

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }
        public int ViewCount { get; set; }

        public string ThumbnailImage { get; set; }

        public List<string> ProductCategories { get; set; } = new List<string>();

    }
}
