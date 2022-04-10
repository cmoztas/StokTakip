using Core.Entities;

namespace Entities.Concrete
{
    public class StockImage : IEntity
    {
        public int Id { get; set; }
        public int StockCardId { get; set; }
        public string Path { get; set; }
        public DateTime? CreateDate { get; set; }
    }

}
