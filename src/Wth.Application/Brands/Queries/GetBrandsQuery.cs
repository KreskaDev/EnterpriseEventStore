using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventFlow.Queries;
using Wth.ReadModel;

namespace Wth.Application.Brands.Queries
{
    public class GetBrandsQuery : IQuery<List<BrandListReadModel>>
    {
    }

    //public class GetUserByUsernameQueryHandler :
    //    IQueryHandler<GetBrandsQuery, List<BrandListReadModel>>
    //{
    //    private IUserReadModelRepository _userReadModelRepository;

    //    public GetUserByUsernameQueryHandler(
    //        IUserReadModelRepository userReadModelRepository)
    //    {
    //        _userReadModelRepository = userReadModelRepository;
    //    }

    //    Task<User> ExecuteQueryAsync(
    //        GetUserByUsernameQuery query,
    //        CancellationToken cancellationToken)
    //    {
    //        return _userReadModelRepository.GetByUsernameAsync(
    //            query.Username,
    //            cancellationToken)
    //    }

    //    public Task<List<BrandListReadModel>> ExecuteQueryAsync(GetBrandsQuery query, CancellationToken cancellationToken)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
