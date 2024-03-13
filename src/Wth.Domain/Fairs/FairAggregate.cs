using EventFlow.Aggregates;
using Wth.Domain.Fairs.Events;

namespace Wth.Domain.Fairs
{
    public class FairAggregate :
        AggregateRoot<FairAggregate, FairId>,
        IEmit<FairCreated>
    {
        public FairAggregate(FairId id) : base(id)
        {
        }

        public void Apply(FairCreated aggregateEvent)
        {
            
        }
    }
}
