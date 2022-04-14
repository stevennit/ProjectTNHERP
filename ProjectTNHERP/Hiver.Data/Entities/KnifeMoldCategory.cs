using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class KnifeMoldCategory : HiverTableFull
    {
        public string Image { get; set; }

        public bool Status { get; set; }

        public List<KnifeMold> KnifeMold { get; set; }
    }
}