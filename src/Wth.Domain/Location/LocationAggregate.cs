using EventFlow.Aggregates;

namespace Wth.Domain.Location
{
    public class LocationAggregate :
        AggregateRoot<LocationAggregate, LocationId>,
        IEmit<LocationCreated>
    {
        public LocationAggregate(LocationId id) : base(id)
        {
        }

        public void Apply(LocationCreated aggregateEvent)
        {

        }
    }
}
