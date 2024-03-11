using EventFlow.Core;

namespace Wth.Domain.Brands;

public class BrandId :
    Identity<BrandId>
{
    public BrandId(string value) : base(value) { }
}