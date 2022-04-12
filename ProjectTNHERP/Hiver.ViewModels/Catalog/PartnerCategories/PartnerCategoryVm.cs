﻿using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.ViewModels.Catalog.PartnerCategories
{
    public class PartnerCategoryVm : HiverTableFull
    {
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public DateTime? DoB { get; set; }
        public Status Status { get; set; }
        public List<string> Partner { set; get; }
    }
}