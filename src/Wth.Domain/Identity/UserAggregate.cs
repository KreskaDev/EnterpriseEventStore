using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventFlow.Aggregates;
using EventFlow.Core;

namespace Wth.Domain.Identity
{
    public class UserId :
        Identity<UserId>
    {
        public UserId(string value) : base(value) { }
    }

    public class UserAggregate :
        AggregateRoot<UserAggregate, UserId>
    {
        public UserAggregate(UserId id) : base(id)
        {
        }
    }
}
