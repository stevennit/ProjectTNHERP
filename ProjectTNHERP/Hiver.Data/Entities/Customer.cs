using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Customer
    {
        public int Id { set; get; }
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

        public int? IdCustomerCompany { get; set; }
        public CustomerCompany CustomerCompany { set; get; }

        public List<OrderSell> OrderSells { get; set; }
    }
}