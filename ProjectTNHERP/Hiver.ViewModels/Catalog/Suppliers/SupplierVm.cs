using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.Suppliers
{
    public class SupplierVm : HiverTableFull
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

        public List<string> OrderBies { get; set; }
    }
}
