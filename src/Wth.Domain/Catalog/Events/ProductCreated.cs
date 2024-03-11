using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventFlow.Aggregates;

namespace Wth.Domain.Catalog.Events
{
    public class ProductCreated : 
        AggregateEvent<ProductAggregate, ProductId>
    {
    }
}
