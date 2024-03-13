using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Commands;
using Wth.Domain.Fairs;

namespace Wth.Application.Fairs
{
    public class NewFairs :
        Command<FairAggregate, FairId, IExecutionResult>
    {
        public NewFairs(FairId aggregateId) : base(aggregateId)
        {
        }
    }


}
