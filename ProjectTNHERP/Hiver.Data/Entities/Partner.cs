using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Partner : HiverTableFull
    {
        public string Code { get; set; }
        public Gender? Gender { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }

        // Mã số thuế
        public string CompanyTaxCode { get; set; }
        public string Country { get; set; }
        public string Tel { get; set; }

        public DateTime? DoB { get; set; }
        public bool Status { get; set; }


        public Guid? IdPartnerCategory { get; set; }
        public PartnerCategory PartnerCategory { set; get; }

    }
}