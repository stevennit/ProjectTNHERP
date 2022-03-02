using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Production : HiverTableUpdate
    {
        public string Title { get; set; }
        public string UserManager { get; set; }

        public Status Status { get; set; }

        public List<ProductionDetail> ProductionDetails { get; set; }
    }
}