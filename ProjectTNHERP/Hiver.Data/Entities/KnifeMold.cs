using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class KnifeMold
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }
        public int? IdKnifeMoldCategory { get; set; }
        public KnifeMoldCategory KnifeMoldCategory { get; set; }
        public List<KnifeMoldImage> KnifeMoldImages { get; set; }
        public List<OrderByDetail> OrderByDetails { get; set; }
    }
}