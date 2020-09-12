using gRPCServer.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPCServer.Data
{
    public static class ProductData
    {
        public static List<ProductModel> ProductModels = new List<ProductModel>
    {
        new ProductModel
        {
            ProductId = 1,
            Name = "Pepsi",
            Description = "Soft Drink",
            Price = 10
        },
        new ProductModel
        {
            ProductId = 2,
            Name = "Fanta",
            Description = "Soft Drink",
            Price = 13
        },
        new ProductModel
        {
            ProductId = 3,
            Name = "Pizza",
            Description = "Fast Food",
            Price = 25
        },
        new ProductModel
        {
            ProductId = 4,
            Name = "French Fries",
            Description = "Fast Food",
            Price = 20
        }
    };
    }
}
