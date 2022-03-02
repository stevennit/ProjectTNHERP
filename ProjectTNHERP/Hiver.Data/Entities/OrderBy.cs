using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class OrderBy : HiverTableFull
    {
        public string Detail { get; set; }

        public Status Status { get; set; }

        public int IdSupplier { get; set; }
        public Supplier Supplier { get; set; }

        public List<OrderByDetail> OrderByDetails { get; set; }
    }
}