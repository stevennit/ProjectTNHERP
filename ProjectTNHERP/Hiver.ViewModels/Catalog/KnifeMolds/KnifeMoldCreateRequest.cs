﻿using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.KnifeMolds
{
    public class KnifeMoldCreateRequest : HiverTableCreate
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public string Detail { get; set; }

        public Status Status { get; set; }

        public int? IdKnifeMoldCategory { get; set; }
        public IFormFile ThumbnailImage { get; set; }
        public List<string> OrderByDetails { get; set; } = new List<string>();
    }
}