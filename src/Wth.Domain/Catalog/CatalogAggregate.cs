using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Aggregates;
using EventFlow.Core;
using Wth.Domain.Brands.Events;
using Wth.Domain.Catalog.Events;

namespace Wth.Domain.Catalog
{
    public class CatalogId :
        Identity<CatalogId>
    {
        public CatalogId(string value) : base(value) { }
    }

    public sealed class CatalogAggregate :
        AggregateRoot<CatalogAggregate, CatalogId>,
        IEmit<CatalogCreated>
    {
        public CatalogAggregate(CatalogId id) : base(id)
        {
            Emit(new CatalogCreated());
        }
        public void Apply(CatalogCreated aggregateEvent)
        {
        }
    }
}
