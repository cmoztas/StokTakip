using Core.Entities;

namespace Entities.Concrete
{
    public class PriceType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
