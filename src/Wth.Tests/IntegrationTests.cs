using EventFlow;
using EventFlow.Extensions;
using EventFlow.Queries;
using FluentAssertions;
using Wth.Application.Brands.Commands;
using Wth.Domain.Brands;
using Wth.ReadModel;

namespace Wth.Tests
{
    public class IntegrationTests
    {
        [Fact]
        public async Task NewBrand()
        {
            using var resolver = EventFlowOptions.New
                .AddEvents(new[] { typeof(BrandRegistered) })
                .AddCommands(new[] { typeof(RegisterNewBrand) })
                .AddCommandHandlers(typeof(RegisterNewBrandHandler))
                .UseInMemoryReadStoreFor<BrandList>()
                .CreateResolver();

            var exampleId = BrandId.New;

            const int magicNumber = 42;

            var commandBus = resolver.Resolve<ICommandBus>();
            var executionResult = await commandBus.PublishAsync(
                    new RegisterNewBrand(exampleId, magicNumber),
                    CancellationToken.None)
                .ConfigureAwait(false);

            executionResult.IsSuccess.Should().BeTrue();

            var queryProcessor = resolver.Resolve<IQueryProcessor>();
            var exampleReadModel = await queryProcessor.ProcessAsync(
                    new ReadModelByIdQuery<BrandList>(exampleId),
                    CancellationToken.None)
                .ConfigureAwait(false);

            exampleReadModel.Brands.Count.Should().Be(1);
            exampleReadModel.Brands[0].MagicNumber.Should().Be(42);
        }

        [Fact]
        public void ApproveNewBrand()
        {

        }

        [Fact]
        public void DeclineNewBrand()
        {

        }


        [Fact]
        public void CreateNewFair()
        {

        }

        [Fact]
        public void ScheaduleFairDate()
        {

        }

        [Fact]
        public void StartFairRegistration()
        {

        }

        [Fact]
        public void SubmitBrandToFair()
        {

        }




        [Fact]
        public void AddBrandItem()
        {

        }

        [Fact]
        public void DeclineBrandItem()
        {

        }

        [Fact]
        public void BuyItem()
        {

        }


    }
}