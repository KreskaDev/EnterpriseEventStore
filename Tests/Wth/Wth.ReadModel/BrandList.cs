using EventFlow.Aggregates;
using EventFlow.ReadStores;
using Wth.Domain.Brands;

namespace Wth.ReadModel
{
    public class BrandReadModel
    {
        public BrandId Id { get; set; }
        public int MagicNumber { get; set; }
    }

    public class BrandList :
        IReadModel,
        IAmReadModelFor<BrandAggregate, BrandId, BrandRegistered>
    {
        public List<BrandReadModel> Brands { get; private set; } = new List<BrandReadModel>();

        public void Apply(
            IReadModelContext context,
            IDomainEvent<BrandAggregate, BrandId, BrandRegistered> domainEvent)
        {
            Brands.Add(new BrandReadModel() { Id = domainEvent.AggregateIdentity, MagicNumber = domainEvent.AggregateEvent.MagicNumber });
        }
    }
}
