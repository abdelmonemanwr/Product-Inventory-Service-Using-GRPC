using System;

namespace ITI.GRPC.Customer.Models
{
    public class ProductData
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Desciption { get; set; }
        public DateTime ProductionDate { get; set; }
    }
}