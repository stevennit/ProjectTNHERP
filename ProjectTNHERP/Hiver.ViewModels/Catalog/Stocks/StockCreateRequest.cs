using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.Stocks
{
    public class StockCreateRequest : HiverTableCreate
    {
        public string Symbol { get; set; }
        public string Code { get; set; }
        public string Detail { get; set; }

        public Status Status { get; set; }

        public int? IdStockCategory { set; get; }
        public List<string> OrderByStocks { set; get; }
        public List<string> StockImages { set; get; }
    }
}
