using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.ProductCategories
{
    public class ProductCategoryCreateRequest : HiverTableCreate
    {
        public string Image { get; set; }

        public bool Status { get; set; }

    }
}
