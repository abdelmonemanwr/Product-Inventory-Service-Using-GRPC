using Microsoft.AspNetCore.Mvc;
using Grpc.Net.Client;
using ITI.GRPC.Customer.Protos;

namespace ITI.GRPC.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(Product product)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7111");
            var client = new InventoryService.InventoryServiceClient(channel);
            var request = new GetProductByIdRequest { ProductId = product.ProductId };
            var response = await client.GetProductByIdAsync(request);
            if (response == null)
            {
                return NotFound(new { message = "No product with the provided Id ... Try again later :)" });
            }
            if (response.IsSuccess == true)
            {
                var updateProductRequest = new UpdateProductRequest { Product = product };
                var updateProductResponse = await client.UpdateProductAsync(updateProductRequest);
                return Ok(new { Status = 201, Product = product, Msg = updateProductResponse.Message });
            }
            else
            {
                var addNewProductRequest = new AddNewProductRequest { Product = product };
                var addNewProductResponse = await client.AddNewProductAsync(addNewProductRequest);
                return Created("", new { Status = 200, Product = product, Msg = addNewProductResponse.Message });
            }
        }
    }
}