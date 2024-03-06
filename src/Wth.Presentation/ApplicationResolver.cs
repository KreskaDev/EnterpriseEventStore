using EventFlow;
using EventFlow.Configuration;
using EventFlow.Extensions;
using Wth.Application.Brands.Commands;
using Wth.Domain.Brands.Events;
using Wth.ReadModel;

namespace Wth.Presentation
{
    public class ApplicationResolver
    {
        public static IRootResolver Resolver => EventFlowOptions.New
            .AddEvents(new[] 
            { 
                typeof(BrandRegistered)
            })
            .AddCommands(new[]
            {
                typeof(RegisterNewBrand)
            })
            .AddCommandHandlers(new []
            {
                typeof(RegisterNewBrandHandler)

            })
            .UseInMemoryReadStoreFor<BrandReadModel>()
            .UseInMemoryReadStoreFor<BrandListReadModel, BrandListReadModelLocator>()
            .CreateResolver();

    }
}
