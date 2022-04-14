﻿using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class KnifeMold : HiverTableFull
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public string Detail { get; set; }

        public bool Status { get; set; }

        public Guid? IdKnifeMoldCategory { get; set; }
        public KnifeMoldCategory KnifeMoldCategory { get; set; }
        public List<KnifeMoldImage> KnifeMoldImages { get; set; }
        public List<Production> Productions { get; set; }
    }
}