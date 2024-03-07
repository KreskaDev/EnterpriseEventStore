using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventFlow.Queries;
using EventFlow.ReadStores.InMemory;
using Wth.Domain.Brands;
using Wth.ReadModel;

namespace Wth.Application.Brands.Queries
{
    public class BrandItemReadModel
    {
        public BrandId BrandId { get; set; }
        public int MagicNumber { get; set; }
    }

    public class GetAllBrandsQuery : IQuery<IReadOnlyCollection<BrandItemReadModel>>
    {
        


    }

    public class GetAllBrandsQueryHandler
        : IQueryHandler<GetAllBrandsQuery, IReadOnlyCollection<BrandItemReadModel>>
    {
        private readonly IInMemoryReadStore<BrandReadModel> _readStore;

        public GetAllBrandsQueryHandler(IInMemoryReadStore<BrandReadModel> readStore)
        {
            _readStore = readStore;
        }

        public async Task<IReadOnlyCollection<BrandItemReadModel>> ExecuteQueryAsync(GetAllBrandsQuery query, CancellationToken cancellationToken)
        {
            var brandsReadModel = await _readStore
                .FindAsync(rm => true, cancellationToken)
                .ConfigureAwait(false);


            return brandsReadModel
                .Select(rm => new BrandItemReadModel()
                {
                    BrandId = rm.Id,
                    MagicNumber = rm.MagicNumber,
                })
                .ToList();
        }
    }
}
