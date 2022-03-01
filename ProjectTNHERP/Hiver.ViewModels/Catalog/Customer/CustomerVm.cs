using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.Customer
{
    public class CustomerVm
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }

        public DateTime DoB { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }

        public string CustomerCompany { get; set; }

        public List<string> OrderSells { get; set; }
    }
}
