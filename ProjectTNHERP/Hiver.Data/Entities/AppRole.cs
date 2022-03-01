using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Description { get; set; }
    }
}
