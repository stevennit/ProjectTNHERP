using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
        public string ImageMore { get; set; }

        public DateTime DoB { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }

        public int? IdSupplierCompany { set; get; }
        public SupplierCompany SupplierCompany { set; get; }

        public List<OrderBy> OrderBies { get; set; }
    }
}