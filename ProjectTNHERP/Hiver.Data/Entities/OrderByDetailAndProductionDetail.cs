namespace Hiver.Data.Entities
{
    public class OrderByDetailAndProductionDetail
    {
        public int Id { get; set; }
        public int IdOrderByDetail { get; set; }
        public OrderByDetail OrderByDetail { get; set; }
        public int IdProductionDetail { get; set; }
        public ProductionDetail ProductionDetail { get; set; }
    }
}