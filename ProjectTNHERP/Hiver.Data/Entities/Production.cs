using Hiver.Utilities.Enums;
using Hiver.Utilities.Table;
using System;
using System.Collections.Generic;

namespace Hiver.Data.Entities
{
    public class Production : HiverTableFull
    {
        public string Title { get; set; }

        public decimal? Qty { get; set; }

        public Status Status { get; set; }

        // Lõi thành phẩm
        public string Core { get; set; }
        // Số lượng đề nghị
        public string QtyRequest { get; set; }
        //Ngày nhập kho
        public string DateEnd { get; set; }
        //Khấu hao
        public string Depreciation { get; set; }

        //
        public Guid? KnifeMoldId { get; set; }

        // Id Nguyễn Liệu - Thành Phẩm
        public Guid? ProductId { get; set; }
        public Guid? UnitId { get; set; }

        // Id  Đơn hàng
        public Guid? OrderSellId { get; set; }
        public OrderSell OrderSell { get; set; }
        public Guid? LSXId { get; set; }

        public List<ProductionStock> ProductionStocks { get; set; }
    }
}