﻿using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class KnifeMoldCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ImageMore { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
        public Status Status { get; set; }

        public List<KnifeMold> KnifeMold { get; set; }
    }
}