using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.Products
{
    public class ProductVm : HiverTableFull
    {
        public string Symbol { get; set; }
        public Double Width { get; set; }
        public Double Height { get; set; }
        public string Detail { get; set; }
       

        public Status Status { get; set; }
        public int? ViewCount { get; set; }

        public string ThumbnailImage { get; set; }

        public List<string> ProductCategories { get; set; } = new List<string>();

    }
}
