using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.Products
{
    public class ProductUpdateRequest : HiverTableUpdate
    {
        public string Symbol { get; set; }
        public Double Width { get; set; }
        public Double Height { get; set; }
        public string Detail { get; set; }

        public Status Status { get; set; }
        public int? ViewCount { get; set; }

        public IFormFile ThumbnailImage { get; set; }

        public IList<int> ProductCategories { get; set; }

    }
}
