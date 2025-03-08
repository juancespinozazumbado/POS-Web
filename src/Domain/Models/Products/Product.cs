using System;

namespace POS.Domain.Models.Products
{

    public class Product
    {
        public Guid Id { get; set; }

        public string ProductName { get; set; } = string.Empty; 
        public string CategoryId { get; set; } = string.Empty;
        public Category Category { get; set; }

        public int Quantity { get; set; } = 0;

       public decimal UnitPrice { get; set; } = decimal.Zero;

        
    }
}
