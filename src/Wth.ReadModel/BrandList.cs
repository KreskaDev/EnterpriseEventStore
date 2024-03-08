using EventFlow.Aggregates;
using EventFlow.ReadStores;
using Wth.Domain.Brands;
using Wth.Domain.Brands.Events;

namespace Wth.ReadModel
{
    public class BrandReadModel :
        IReadModel,
        IAmReadModelFor<BrandAggregate, BrandId, BrandRegistered>
    {
        public BrandId Id { get; set; }
        public int MagicNumber { get; set; }
        public void Apply(IReadModelContext context, IDomainEvent<BrandAggregate, BrandId, BrandRegistered> domainEvent)
        {
            MagicNumber = domainEvent.AggregateEvent.MagicNumber;
        }
    }
}
