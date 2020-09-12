using Grpc.Core;
using gRPCServer.Data;
using gRPCServer.Protos;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPCServer.Services
{
    public class ProductService : Product.ProductBase
    {
        private readonly ILogger<ProductService> _logger;
        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }

        public override Task<ProductModel> GetProductById(GetProductByIdModel request, ServerCallContext context)
        {
            var product = ProductData.ProductModels.Where(p => p.ProductId == request.ProductId).FirstOrDefault();
            if (product != null)
            {
                return Task.FromResult(product);
            }
            else
            {
                return null;
            }
        }
        public override async Task GetAllProducts(GetAllProductsRequest request, IServerStreamWriter<ProductModel> responseStream, ServerCallContext context)
        {
            var allProducts = ProductData.ProductModels.ToList();
            foreach (var product in allProducts)
            {
                await responseStream.WriteAsync(product);
            }
        }
    }
}
