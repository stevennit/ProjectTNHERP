using Hiver.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Catalog.Stocks
{
    public class StockVm
    {
        public string Symbol { get; set; }
        public string Code { get; set; }
        public string Detail { get; set; }

        public bool Status { get; set; }

        public int? IdStockCategory { set; get; }
        public List<string> OrderByStocks { set; get; }
        public List<string> StockImages { set; get; }
    }
}
