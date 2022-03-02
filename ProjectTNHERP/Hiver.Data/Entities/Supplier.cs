﻿using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Supplier : HiverTableFull
    {
        public Gender? Gender { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }

        public DateTime? DoB { get; set; }

        public Status Status { get; set; }

        public int? IdSupplierCompany { set; get; }
        public SupplierCompany SupplierCompany { set; get; }

        public List<OrderBy> OrderBies { get; set; }
    }
}