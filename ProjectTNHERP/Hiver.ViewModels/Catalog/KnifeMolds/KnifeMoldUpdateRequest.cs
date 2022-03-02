﻿using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.KnifeMolds
{
    public class KnifeMoldUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }
        public int? IdKnifeMoldCategory { get; set; }
        public string ThumbnailImage { get; set; }
        public List<string> OrderByDetails { get; set; } = new List<string>();
    }
}
