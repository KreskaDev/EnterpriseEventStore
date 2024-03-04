using EventFlow.Aggregates;
using EventFlow.EventStores;

namespace Wth.Domain.Brands
{
    [EventVersion("example", 1)]
    public class BrandRegistered :
        AggregateEvent<BrandAggregate, BrandId>
    {
        public BrandRegistered(int magicNumber)
        {
            MagicNumber = magicNumber;
        }

        public int MagicNumber { get; }
    }
}
