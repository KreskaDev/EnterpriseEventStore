using EventFlow.Aggregates;
using EventFlow.Aggregates.ExecutionResults;
using Wth.Domain.Brands.Events;

namespace Wth.Domain.Brands
{
    public class BrandAggregate :
        AggregateRoot<BrandAggregate, BrandId>,
        IEmit<BrandRegistered>
    {
        private int? _magicNumber;

        public BrandAggregate(BrandId id) : base(id) { }

        public IExecutionResult SetMagicNumer(int magicNumber)
        {
            if (_magicNumber.HasValue)
                return ExecutionResult.Failed("Magic number already set");

            Emit(new BrandRegistered(magicNumber));

            return ExecutionResult.Success();
        }

        public void Apply(BrandRegistered aggregateEvent)
        {
            _magicNumber = aggregateEvent.MagicNumber;
        }
    }
}
