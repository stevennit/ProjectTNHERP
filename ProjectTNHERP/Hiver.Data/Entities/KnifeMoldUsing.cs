using System;

namespace Hiver.Data.Entities
{
    public class KnifeMoldUsing
    {
        public int Id { get; set; }
        public int? UserUsingStart { get; set; }
        public DateTime? DateUsingStart { get; set; }
        public int? UserUsingEnd { get; set; }
        public DateTime? DateUsingEnd { get; set; }

        public int IdProductionDetail { get; set; }
        public ProductionDetail ProductionDetail { get; set; }
    }
}