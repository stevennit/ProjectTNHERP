﻿using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.Partners
{
    public class PartnerUpdateRequest : HiverTableUpdate
    {
        public Gender? Gender { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }

        public DateTime? DoB { get; set; }

        public bool Status { get; set; }

        public int? IdPartnerCategory { get; set; }

    }
}
