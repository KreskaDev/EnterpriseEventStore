using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventFlow.Aggregates;
using Wth.Domain.Catalog.Events;

namespace Wth.Domain.Catalog
{
    public class ProductAggregate :
        AggregateRoot<ProductAggregate, ProductId>,
        IEmit<ProductCreated>
    {
        public ProductAggregate(ProductId id) : base(id)
        {
        }

        public void Apply(ProductCreated aggregateEvent)
        {
            throw new NotImplementedException();
        }
    }
}
