using EventFlow;
using EventFlow.Queries;
using FluentAssertions;
using Wth.Application.Brands.Commands;
using Wth.Application.Brands.Queries;
using Wth.Domain.Brands;
using Wth.Presentation;
using Wth.ReadModel;

namespace Wth.Tests
{
    public class IntegrationTests
    {
        [Fact]
        public async Task NewBrand()
        {
            using var resolver = ApplicationResolver.Resolver;

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
                    new GetAllBrandsQuery(),
                    CancellationToken.None)
                .ConfigureAwait(false);

            exampleReadModel.Count.Should().Be(1);
            exampleReadModel.ToArray()[0].MagicNumber.Should().Be(42);
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
        public void ScheduleFairDate()
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