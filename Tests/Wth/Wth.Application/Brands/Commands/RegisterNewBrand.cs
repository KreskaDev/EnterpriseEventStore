
using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Commands;
using Wth.Domain.Brands;

namespace Wth.Application.Brands.Commands
{
    public class RegisterNewBrand :
        Command<BrandAggregate, BrandId, IExecutionResult>
    {
        public RegisterNewBrand(
            BrandId aggregateId,
            int magicNumber)
            : base(aggregateId)
        {
            MagicNumber = magicNumber;
        }

        public int MagicNumber { get; }
    }

    public class RegisterNewBrandHandler :
       CommandHandler<BrandAggregate, BrandId, IExecutionResult, RegisterNewBrand>
    {
        public override Task<IExecutionResult> ExecuteCommandAsync(
            BrandAggregate aggregate,
            RegisterNewBrand command,
            CancellationToken cancellationToken)
        {
            var executionResult = aggregate.SetMagicNumer(command.MagicNumber);
            return Task.FromResult(executionResult);
        }
    }
}
