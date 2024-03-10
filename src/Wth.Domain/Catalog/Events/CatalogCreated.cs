using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventFlow.Aggregates;
using Wth.Domain.Brands;

namespace Wth.Domain.Catalog.Events
{
    public class CatalogCreated :
        AggregateEvent<CatalogAggregate, CatalogId>
    {
    }
}
