using EventFlow.Core;

namespace Wth.Domain.Catalog;

public class CatalogId :
    Identity<CatalogId>
{
    public CatalogId(string value) : base(value) { }
}