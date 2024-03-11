using EventFlow.Core;

namespace Wth.Domain.Basket;

public class BasketId :
    Identity<BasketId>
{
    public BasketId(string value) : base(value) { }
}