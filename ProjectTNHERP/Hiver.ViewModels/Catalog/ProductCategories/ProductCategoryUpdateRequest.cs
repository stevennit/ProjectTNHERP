﻿using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.Catalog.ProductCategories
{
    public class ProductCategoryUpdateRequest : HiverTableUpdate
    {
        public string Image { get; set; }

        public bool Status { get; set; }
    }
}
