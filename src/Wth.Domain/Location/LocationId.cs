using EventFlow.Core;

namespace Wth.Domain.Location;

public class LocationId :
    Identity<LocationId>
{
    public LocationId(string value) : base(value) { }
}