using EventFlow.Aggregates;
using EventFlow.ReadStores;
using Wth.Domain.Brands;
using Wth.Domain.Brands.Events;

namespace Wth.ReadModel
{
    public class BrandReadModel :
        IReadModel,
        IAmReadModelFor<BrandAggregate, BrandId, BrandRegistered>
    {
        public BrandId Id { get; set; }
        public int MagicNumber { get; set; }
        public void Apply(IReadModelContext context, IDomainEvent<BrandAggregate, BrandId, BrandRegistered> domainEvent)
        {
            MagicNumber = domainEvent.AggregateEvent.MagicNumber;
        }
    }

    //public class BrandListReadModelLocator : IReadModelLocator
    //{
    //    public IEnumerable<string> GetReadModelIds(IDomainEvent domainEvent)
    //    {
    //        var userNicknameAdded = domainEvent as
    //            IDomainEvent<BrandAggregate, BrandId, BrandRegistered>;
    //        if (userNicknameAdded == null)
    //        {
    //            yield break;
    //        }

    //        yield return userNicknameAdded.AggregateIdentity.ToString();
    //    }
    //}




    

    //public class BrandListReadModel :
    //    IReadModel,
    //    IAmReadModelFor<BrandAggregate, BrandId, BrandRegistered>
    //{
    //    public List<BrandItem> Brands { get; } = new();

    //    public void Apply(
    //        IReadModelContext context,
    //        IDomainEvent<BrandAggregate, BrandId, BrandRegistered> domainEvent)
    //    {
    //        Brands.Add(new BrandItem
    //        {
    //            BrandId = domainEvent.AggregateIdentity,
    //            MagicNumber = domainEvent.AggregateEvent.MagicNumber
    //        });
    //    }
    //}
}
