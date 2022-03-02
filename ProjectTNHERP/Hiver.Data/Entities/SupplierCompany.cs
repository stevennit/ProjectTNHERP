using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class SupplierCompany : HiverTableFull
    {
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }

        public DateTime? DoB { get; set; }
        public DateTime? DateWorkFirst { get; set; }
        public DateTime? DateWorkEnd { get; set; }

        public Status Status { get; set; }

        public List<Supplier> Suppliers { set; get; }
    }
}