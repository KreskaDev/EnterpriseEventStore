using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Commands;
using Wth.Domain.Fairs;

namespace Wth.Application.Fairs
{
    public class AddFairSlots :
        Command<FairAggregate, FairId, IExecutionResult>
    {
        public FairSlotSize FairSlotSize { get; set; }

        public AddFairSlots(FairId aggregateId) : base(aggregateId)
        {
        }
    }
}
