using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.SupplierCompanies
{
    internal class SupplierCompanyUpdateRequest : HiverTableUpdate
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

        public List<string> Suppliers { set; get; }
    }
}
