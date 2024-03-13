using EventFlow.Aggregates;

namespace Wth.Domain.Fairs.Events;

public class FairCreated :
    AggregateEvent<FairAggregate, FairId>
{
}