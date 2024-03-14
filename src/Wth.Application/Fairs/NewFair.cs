using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Commands;
using Wth.Domain.Fairs;

namespace Wth.Application.Fairs
{
    public class NewFair :
        Command<FairAggregate, FairId, IExecutionResult>
    {
        public NewFair(FairId aggregateId) : base(aggregateId)
        {
        }
    }


}
