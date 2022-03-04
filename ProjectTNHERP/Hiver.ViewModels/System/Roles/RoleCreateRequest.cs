﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.System.Roles
{
    public class RoleCreateRequest
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
