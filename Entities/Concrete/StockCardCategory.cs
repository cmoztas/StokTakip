using Core.Entities;

namespace Entities.Concrete
{
    public class StockCardCategory : IEntity
    {
        public int Id { get; set; }
        public int StockCardId { get; set; }
        public int CategoryId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
