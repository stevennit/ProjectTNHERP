using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.ProductCategories
{
    public class ProductCategoryVm : HiverTableFull
    {
        public string Image { get; set; }

        public Status Status { get; set; }
    }
}
