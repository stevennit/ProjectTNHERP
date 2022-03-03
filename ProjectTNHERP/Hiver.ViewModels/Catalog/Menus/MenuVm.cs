﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.Menus
{
    public class MenuVm
    {
        public int MenuID { get; set; }
        public int? ParentID { get; set; }
        public int? MenuOrder { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public string IconNumber { get; set; }
        public string Url { get; set; }
        public int MenuVisible { get; set; }
        public bool IsVisible { get; set; }
    }
}
