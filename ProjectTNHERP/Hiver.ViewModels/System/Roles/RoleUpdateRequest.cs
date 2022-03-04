using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.System.Roles
{
    public class RoleUpdateRequest
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
