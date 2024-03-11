using EventFlow.Aggregates;
using EventFlow.Aggregates.ExecutionResults;
using Wth.Domain.Basket.Events;
using Wth.Domain.Catalog;

namespace Wth.Domain.Basket
{
    public sealed class BasketAggregate :
        AggregateRoot<BasketAggregate, BasketId>,
        IEmit<BasketCreated>
    {
        public BasketAggregate(BasketId id) : base(id)
        {
            Emit(new BasketCreated());
        }
        public void Apply(BasketCreated aggregateEvent)
        {
        }

        public IExecutionResult AddProduct()
        {
            throw new NotImplementedException();
            return ExecutionResult.Success();
        }

        public IExecutionResult AddProduct(ProductId commandProductId, int commandCount)
        {
            throw new NotImplementedException();
            return ExecutionResult.Success();
        }
    }
}
