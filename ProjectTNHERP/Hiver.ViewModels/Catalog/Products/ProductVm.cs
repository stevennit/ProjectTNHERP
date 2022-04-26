using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using Hiver.ViewModels.Catalog.ProductCategories;
using Hiver.ViewModels.Catalog.ProductImages;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.Products
{
    public class ProductVm : HiverTableFull
    {
        public string Code { get; set; }
        public Double Width { get; set; }
        public Double Height { get; set; }
        public string Detail { get; set; }
       

        public bool Status { get; set; }
        public int? ViewCount { get; set; }

        public string Image { get; set; }

        public List<Guid> ProductCategories { get; set; }

    }
}
