using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using EventFlow.Aggregates.ExecutionResults;
using EventFlow.Commands;
using EventFlow.Core;
using Wth.Application.Brands.Commands;
using Wth.Domain.Basket;
using Wth.Domain.Brands;
using Wth.Domain.Catalog;

namespace Wth.Application.Bascet
{
    public class AddProduct :
        Command<BasketAggregate, BasketId, IExecutionResult>
    {
        public ProductId ProductId { get; set; }
        public int Count { get; set; }
        public AddProduct(BasketId aggregateId, ProductId productId, int count) : base(aggregateId)
        {
            ProductId = productId;
            Count = count;
        }
        //public AddProduct(BasketId aggregateId, ISourceId sourceId) : base(aggregateId, sourceId)
        //{
        //}

    }

    public class AddProductHandler 
        : CommandHandler<BasketAggregate, BasketId, IExecutionResult, AddProduct>
    {
        public override Task<IExecutionResult> ExecuteCommandAsync(
            BasketAggregate aggregate, AddProduct command, CancellationToken cancellationToken)
        {
            //TODO: Make happened
            //var product = _productRepository.GetById(command.ProductId);

            var executionReulst = aggregate.AddProduct(command.ProductId, command.Count);
            return Task.FromResult(executionReulst);
        }
    }
}
