using Grpc.Core;
using ITI.GRPC.Server.Models;
using ITI.GRPC.Server.Protos;
using static ITI.GRPC.Server.Protos.InventoryService;

namespace ITI.GRPC.Server.Services
{
    public class MessageInventoryService:InventoryServiceBase
    {
        private readonly ILogger<MessageInventoryService> logger;

        public MessageInventoryService(ILogger<MessageInventoryService> logger)
        {
            this.logger = logger;
        }

        public override async Task<GetProductByIdResponse> GetProductById(GetProductByIdRequest request, ServerCallContext context)
        {

            var product = ProductList.Products.FirstOrDefault(p => p.ProductId == request.ProductId);

            return await Task.FromResult(new GetProductByIdResponse {
                Product = product
            });
        }

        public override Task<AddNewProductResponse> AddNewProduct(AddNewProductRequest request, ServerCallContext context)
        {
            ProductList.Products.Add(request.Product);
            return Task.FromResult(new AddNewProductResponse {
                Product= request.Product,
                IsSuccess = true
            });
        }

        //public override Task<UpdateProductResponse> UpdateProduct(UpdateProductRequest request, ServerCallContext context)
        //{
        //    var product = ProductList.Products.FirstOrDefault(p => p.ProductId == request.Product.ProductId);
        //    if (product == null)
        //    {
        //        return Task.FromResult(new UpdateProductResponse
        //        {
        //            Product = new Product(),
        //            IsSuccess = false
        //        });
        //    }

        //    ProductList.Products.Remove(product);
        //    ProductList.Products.Add(request.Product);
        //    return Task.FromResult(new UpdateProductResponse
        //    {
        //        Product = request.Product,
        //        IsSuccess = true
        //    });
        //}

        public override Task<UpdateProductResponse> UpdateProduct(UpdateProductRequest request, ServerCallContext context)
        {
            var product = ProductList.Products.FirstOrDefault(p => p.ProductId == request.Product.ProductId);
            if (product == null)
            {
                return Task.FromResult(new UpdateProductResponse
                {
                    Product = new Product(),
                    IsSuccess = false
                });
            }
             
            product.Name = request.Product.Name;
            product.Price = request.Product.Price;
            product.Quantity = request.Product.Quantity;
            product.Description = request.Product.Description;
            product.ProductionDate = request.Product.ProductionDate;
   
            return Task.FromResult(new UpdateProductResponse
            {
                Product = request.Product,
                IsSuccess = true
            });
        }
    }
}
