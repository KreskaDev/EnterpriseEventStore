using EventFlow.Aggregates;

namespace Wth.Domain.Location;

public class LocationCreated :
    AggregateEvent<LocationAggregate, LocationId>
{
}