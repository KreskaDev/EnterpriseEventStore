using EventFlow.Aggregates;

namespace Wth.Domain.Basket.Events
{
    public class BasketCreated :
        AggregateEvent<BasketAggregate, BasketId>
    {

    }
}
