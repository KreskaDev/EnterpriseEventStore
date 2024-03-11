using EventFlow.Core;

namespace Wth.Domain.Catalog;

public class ProductId :
    Identity<ProductId>
{
    public ProductId(string value) : base(value) { }
}