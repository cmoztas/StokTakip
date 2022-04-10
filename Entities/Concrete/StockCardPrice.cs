using Core.Entities;

namespace Entities.Concrete
{
    public class StockCardPrice : IEntity
    {
        public int Id { get; set; }
        public int StockCardId { get; set; }
        public int PriceTypeId { get; set; }
        public int CurrencyId { get; set; }
        public decimal Price { get; set; }
        public bool WatIncluded { get; set; }
        public DateTime? CreateDate { get; set; }
    }

}
