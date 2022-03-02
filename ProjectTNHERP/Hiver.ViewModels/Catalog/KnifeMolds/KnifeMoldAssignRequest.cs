using Hiver.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.KnifeMolds
{
    public class KnifeMoldAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> KnifeMoldCategory { get; set; } = new List<SelectItem>();
    }
}
