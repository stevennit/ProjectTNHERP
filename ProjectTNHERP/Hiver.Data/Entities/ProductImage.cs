using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class ProductImage : HiverTableImageFull
    {
        public Product Product { get; set; }
    }
}