using EventFlow.Core;

namespace Wth.Domain.Fairs;

public class FairId :
    Identity<FairId>
{
    public FairId(string value) : base(value) { }
}