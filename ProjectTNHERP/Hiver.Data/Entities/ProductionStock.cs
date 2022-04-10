using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.Data.Entities
{
    public class ProductionStock 
    {
        public Guid Id { get; set; }
        public Guid? ProductionId { get; set; }
        public Guid? StockId { get; set; }
        public Guid? UnitId { get; set; }
        public decimal Qty { get; set; }

    }
}
