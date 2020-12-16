using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Production
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserManager { get; set; }
        public string Description { get; set; }

        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }

        public List<ProductionDetail> ProductionDetails { get; set; }
    }
}