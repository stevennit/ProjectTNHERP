﻿using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Data.Entities
{
    public class LSX : HiverTableFull
    {
       public List<Production> Productions { get; set; }
    }
}