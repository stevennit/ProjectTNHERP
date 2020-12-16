using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class KnifeMoldImage
    {
        public int Id { get; set; }

        public int? IdKnifeMold { get; set; }

        public string ImagePath { get; set; }

        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public DateTime DateCreated { get; set; }

        public int SortOrder { get; set; }

        public long FileSize { get; set; }

        public KnifeMold KnifeMold { get; set; }

    }
}