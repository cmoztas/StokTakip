using Core.Entities;

namespace Entities.Concrete
{
    public class StockCard : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UnitTypeId { get; set; }
        public int? BrandId { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; }
        public string? Barcode { get; set; }
        public double? CriticalStockLevel { get; set; }
        public string? Note1 { get; set; }
        public string? Note2 { get; set; }
        public string? Decription { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
