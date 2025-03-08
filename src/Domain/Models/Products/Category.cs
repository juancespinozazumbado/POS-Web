

using System.Collections;

namespace POS.Domain.Models.Products
{
    public class ProductCategory : EntityBase
    {
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
        public IList<Product>? Products { get; set; }

    }
}
