using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class SupplierCompany
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ImageMore { get; set; }

        public DateTime DoB { get; set; }
        public DateTime DateWorkFirst { get; set; }
        public DateTime DateWorkEnd { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }

        public List<Supplier> Suppliers { set; get; }
    }
}