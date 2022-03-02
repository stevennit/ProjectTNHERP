using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.StockCategories
{
    public class StockCategoryCreateRequest : HiverTableCreate
    {
        public string Image { get; set; }

        public Status Status { get; set; }

        public List<string> Stocks { get; set; }
    }
}
