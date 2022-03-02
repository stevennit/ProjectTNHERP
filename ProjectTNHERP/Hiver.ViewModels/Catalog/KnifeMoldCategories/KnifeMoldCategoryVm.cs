using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.KnifeMoldCategories
{
    public class KnifeMoldCategoryVm : HiverTableFull
    {
        public string Image { get; set; }

        public Status Status { get; set; }

        public List<string> KnifeMold { get; set; } = new List<string>();
    }
}
