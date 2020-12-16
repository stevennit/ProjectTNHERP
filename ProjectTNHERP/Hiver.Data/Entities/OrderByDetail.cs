using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class OrderByDetail
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }

        public int IdStock { get; set; }
        public Stock Stock { get; set; }
        public int IdOrderBy { get; set; }
        public OrderBy OrderBy { get; set; }

        public List<OrderByDetailAndProductionDetail> OrderByDetailAndProductionDetails { get; set; }
    }
}